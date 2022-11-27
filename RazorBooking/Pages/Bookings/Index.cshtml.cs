using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooking.Models;

namespace RazorBooking.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly RazorBooking.Data.RazorBookingContext _context;

        public IndexModel(RazorBooking.Data.RazorBookingContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bookings != null)
            {
                Booking = await _context.Bookings.ToListAsync();
            }
        }
    }
}
