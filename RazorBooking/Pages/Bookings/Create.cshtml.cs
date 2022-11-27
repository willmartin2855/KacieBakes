using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBooking.Data;
using RazorBooking.Models;

namespace RazorBooking.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly RazorBookingContext _context;

        public CreateModel(RazorBookingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Bookings == null || Booking == null)
          {
              return Page();
          }

            var relevantBookings = _context.Bookings.Where(
                b => b.Location.Id == Booking.Location.Id && 
                b.StartTime.Date == Booking.StartTime.Date);

            foreach (var booking in relevantBookings)
            {
                if((booking.StartTime >= Booking.StartTime && booking.StartTime <= Booking.EndTime) || 
                    (booking.EndTime >= Booking.StartTime && booking.EndTime <= booking.EndTime))
                    return RedirectToPage("./Error");
            }

          _context.Bookings.Add(Booking);
          await _context.SaveChangesAsync();

          return RedirectToPage("./Index");
        }
    }
}
