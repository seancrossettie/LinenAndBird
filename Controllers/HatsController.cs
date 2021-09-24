using System.Collections.Generic;
using System.Linq;
using LinenAndBird.Controllers;
using Microsoft.AspNetCore.Mvc;
using static LinenAndBird.Controllers.Hat;

namespace LinenAndBird.Models
{
    [Route("api/hats")] // Exposed at this endpoint
    [ApiController] // An api controller, so it returns json or xml
    public class HatsController : ControllerBase
    {

        static List<Hat> _hats = new List<Hat>
        {
            new Hat
            {
                Color = "Blue",
                Designer = "Charlie",
                Style = Hat.HatStyle.OpenBack
            },
            new Hat
            {
                Color = "Blue",
                Designer = "Charlie",
                Style = Hat.HatStyle.OpenBack
            },
            new Hat
            {
                Color = "Blue",
                Designer = "Charlie",
                Style = Hat.HatStyle.OpenBack
            }
        };

        [HttpGet]
        public List<Hat> GetAllHats()
        {
            return _hats;
        }

        [HttpGet("styles/{style}")]
        public IEnumerable<Hat> GetHatsByStyle(HatStyle style)
        {
            var matches = _hats.Where(hat => hat.Style == style);

            return matches;
        }

        [HttpPost]
        public void AddAHat(Hat newHat)
        {
            _hats.Add(newHat);
        }

    }
}
