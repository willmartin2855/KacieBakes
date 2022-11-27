using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Start Time")]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [Display(Name = "End Time")]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

    }
}
