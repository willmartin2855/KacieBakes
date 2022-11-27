using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorBooking.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Time)]
        public DateTime Opens { get; set; }
        [DataType(DataType.Time)]
        public DateTime Closes { get; set; }
        [Display(Name = "Hourly Rate")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HourlyRate { get; set; }
    }
}
