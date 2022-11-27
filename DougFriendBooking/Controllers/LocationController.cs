using DougFriendBooking.Models;
using DougFriendBooking.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DougFriendBooking.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepo _locationRepo;

        public LocationController(ILocationRepo locationRepo)
        {
            _locationRepo = locationRepo;
        }

        public async Task<IActionResult> List()
        {
            var locations = JsonSerializer.Serialize(_locationRepo.AllLocations);
            return Ok(locations);
        }

        public async Task<IActionResult> GetLocationByName(string name)
        {
            var location = JsonSerializer.Serialize(_locationRepo.AllLocations.FirstOrDefault(l => l.Name == name));
            return Ok(location);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(LocationAddViewModel model)
        {
            _locationRepo.AddLocation(model.Name);
            return Ok();
        }
    }
}
