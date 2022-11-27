namespace DougFriendBooking.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var bookingContext = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookingDbContext>();

            if (!bookingContext.Locations.Any())
            {
                bookingContext.AddRange
                    (
                        new Location
                        {
                            Name = "Location1"
                        },
                        new Location
                        {
                            Name = "Location2"
                        }, new Location
                        {
                            Name = "Location3"
                        }, new Location
                        {
                            Name = "Location4"
                        }
                    );
            }

            if (!bookingContext.Bookings.Any())
            {
                bookingContext.AddRange
                    (
                        new Booking
                        {
                            LocationId = 1,
                            StartTime = 10,
                            EndTime = 11,
                        },
                        new Booking
                        {
                            LocationId = 2,
                            StartTime = 10,
                            EndTime = 11,
                        },
                        new Booking
                        {
                            LocationId = 3,
                            StartTime = 10,
                            EndTime = 11,
                        },
                        new Booking
                        {
                            LocationId = 4,
                            StartTime = 10,
                            EndTime = 11,
                        }
                    );
            }

            bookingContext.SaveChanges();
        }
    }
}
