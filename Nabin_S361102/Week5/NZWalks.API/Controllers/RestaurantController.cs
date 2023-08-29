using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
   
    // https://localhost:portnumber/api/restaurant
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllRestaurants()
        {
            String[] restaurants = new String[] { "Supero","A&Z","ABC"};

            return Ok(restaurants);
        }
    }
}
