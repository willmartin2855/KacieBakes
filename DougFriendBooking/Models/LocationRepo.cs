namespace DougFriendBooking.Models
{
    public class LocationRepo : ILocationRepo
    {
        private readonly BookingDbContext _bookingSiteDbContext;

        public LocationRepo(BookingDbContext bookingSiteDbContext)
        {
            _bookingSiteDbContext = bookingSiteDbContext;
        }

        public IEnumerable<Location> AllLocations
        {
            get
            {
                return _bookingSiteDbContext.Locations;
            }
        }

        public Location? GetLocationByName(string name)
        {
            return _bookingSiteDbContext.Locations.FirstOrDefault(x => x.Name == name);
        }

        public bool AddLocation(string name)
        {
            _bookingSiteDbContext.Locations.Add(new Location { Name = name });
            _bookingSiteDbContext.SaveChanges();
            return true;
        }
    }
}
