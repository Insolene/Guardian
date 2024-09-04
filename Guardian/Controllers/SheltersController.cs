using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Guardian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheltersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetMapsLink()
        {
            var mapsLink = "https://www.google.com/maps/@?api=1&map_action=map&center=-27.0999679604572%2C-48.91699220486182&zoom=15";
            return Ok(mapsLink);
        }
    }
}
