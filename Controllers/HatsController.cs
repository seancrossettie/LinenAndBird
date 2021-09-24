using System.Collections.Generic;
using LinenAndBird.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace LinenAndBird.Models
{
    [Route("api/hats")] // Exposed at this endpoint
    [ApiController] // An api controller, so it returns json or xml
    public class HatsController : ControllerBase
    {

        [HttpGet]
        public List<Hat> GetAllHats()
        {
            return new List<Hat>
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
        }

    }
}
