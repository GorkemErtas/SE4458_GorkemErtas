using Microsoft.AspNetCore.Mvc;
using AirlineAPI.Data;
using AirlineAPI.Models;

namespace AirlineAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly AirlineDbContext _context;

        public TicketController(AirlineDbContext context)
        {
            _context = context;
        }

        
        [HttpPost("BuyTicket")]
        public async Task<IActionResult> BuyTicket(int flightId, string passengerName)
        {
            var flight = await _context.Flights.FindAsync(flightId);

            if (flight == null || flight.Capacity <= 0)
                return BadRequest("Flight not found or no available seats.");

            
            var ticket = new Ticket(flightId, passengerName, false);

            
            flight.Capacity--;
            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();

            return Ok(new { Status = "Success", Message = "Ticket booked successfully." });
        }

        
        [HttpPost("CheckIn")]
        public async Task<IActionResult> CheckIn(int ticketId)
        {
            var ticket = await _context.Tickets.FindAsync(ticketId);

            if (ticket == null)
                return NotFound("Ticket not found.");

            ticket.IsCheckedIn = true;
            await _context.SaveChangesAsync();

            return Ok(new { Status = "Success", Message = "Check-in completed." });
        }
    }
}
