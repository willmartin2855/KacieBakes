using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooking.Models;

namespace RazorBooking.Pages.Locations
{
    public class IndexModel : PageModel
    {
        private readonly Data.RazorBookingContext _context;

        public IndexModel(Data.RazorBookingContext context)
        {
            _context = context;
        }

        public IList<Location> Location { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Location != null)
            {
                Location = await _context.Location.ToListAsync();
            }
        }
    }
}
