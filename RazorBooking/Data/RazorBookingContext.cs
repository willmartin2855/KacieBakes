using Microsoft.EntityFrameworkCore;
using RazorBooking.Models;

namespace RazorBooking.Data
{
    public class RazorBookingContext : DbContext
    {
        public RazorBookingContext (DbContextOptions<RazorBookingContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Location { get; set; } = default!;
        public DbSet<Booking> Bookings { get; set; }
    }
}
