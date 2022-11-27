using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooking.Data;
using RazorBooking.Models;

namespace RazorBooking.Pages.Locations
{
    public class DetailsModel : PageModel
    {
        private readonly RazorBooking.Data.RazorBookingContext _context;

        public DetailsModel(RazorBooking.Data.RazorBookingContext context)
        {
            _context = context;
        }

      public Location Location { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Location == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FirstOrDefaultAsync(m => m.Id == id);
            if (location == null)
            {
                return NotFound();
            }
            else 
            {
                Location = location;
            }
            return Page();
        }
    }
}
