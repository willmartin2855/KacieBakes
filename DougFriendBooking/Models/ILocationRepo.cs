namespace DougFriendBooking.Models
{
    public interface ILocationRepo
    {
        IEnumerable<Location> AllLocations { get; }
        Location? GetLocationByName(string name);
        bool AddLocation(string name);
    }
}
