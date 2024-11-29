using Microsoft.EntityFrameworkCore;
using AirlineAPI.Models; // Flight, Ticket, Passenger sınıflarının bulunduğu namespace


namespace AirlineAPI.Data
{
    public class AirlineDbContext : DbContext
    {
        public AirlineDbContext(DbContextOptions<AirlineDbContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
    }
}
