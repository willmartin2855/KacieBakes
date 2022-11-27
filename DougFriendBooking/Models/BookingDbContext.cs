using Microsoft.EntityFrameworkCore;

namespace DougFriendBooking.Models
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
