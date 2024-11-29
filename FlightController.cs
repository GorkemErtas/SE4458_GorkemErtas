using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirlineAPI.Data;
using AirlineAPI.Models;

namespace AirlineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly AirlineDbContext _context;

        public FlightController(AirlineDbContext context)
        {
            _context = context;
        }

    
        [HttpPost("InsertFlight")]
        public async Task<IActionResult> InsertFlight([FromBody] Flight flight)
        {
            if (flight == null || flight.Capacity <= 0 || flight.Date < DateTime.Now)
            {
                return BadRequest("Invalid data.");
            }

            try
            {
                
                await _context.Flights.AddAsync(flight);

                
                await _context.SaveChangesAsync();

                return Ok(new { Status = "Successfull", Message = "Flight has added succesfully." });
            }
            catch (DbUpdateException ex)
            {
                
                return StatusCode(500, new { Status = "Error", Message = "Occurs an error.", Details = ex.Message });
            }
        }

        
        [HttpGet("ReportFlights")]
        public async Task<IActionResult> ReportFlights([FromQuery] string from, [FromQuery] string to, [FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate)
        {
            
            var flights = await _context.Flights
                .Where(f => f.From == from && f.To == to 
                           && (startDate == null || f.Date >= startDate)
                           && (endDate == null || f.Date <= endDate))
                .ToListAsync();

            if (flights.Count == 0)
                return NotFound("No flights found.");

            return Ok(flights);
        }
    }
}
