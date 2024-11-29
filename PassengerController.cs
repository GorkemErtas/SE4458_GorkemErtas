using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirlineAPI.Data;
using AirlineAPI.Models;

namespace AirlineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassengerController : ControllerBase
    {
        private readonly AirlineDbContext _context;

        public PassengerController(AirlineDbContext context)
        {
            _context = context;
        }

        
        [HttpGet("QueryFlights")]
        public async Task<IActionResult> QueryFlights([FromQuery] string from, [FromQuery] string to, [FromQuery] DateTime date)
        {
            
            var flights = await _context.Flights
                .Where(f => f.From == from && f.To == to && f.Date.Date == date.Date && f.Capacity > 0)
                .ToListAsync();

            if (flights.Count == 0)
                return NotFound("No available flights found.");

            return Ok(flights);
        }
    }
}
