using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DougFriendBooking.ViewModels
{
    [BindProperties]
    public class LocationAddViewModel : PageModel
    {
        public string Name { get; set; }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
