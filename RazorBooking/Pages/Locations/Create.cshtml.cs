using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBooking.Models;

namespace RazorBooking.Pages.Locations
{
    public class CreateModel : PageModel
    {
        private readonly Data.RazorBookingContext _context;

        public CreateModel(Data.RazorBookingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Location Location { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Location == null || Location == null)
            {
                return Page();
            }

            _context.Location.Add(Location);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
