namespace DougFriendBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
    }
}
