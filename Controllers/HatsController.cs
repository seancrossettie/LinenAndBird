using System.Collections.Generic;
using System.Linq;
using LinenAndBird.DataAccesLayer;
using LinenAndBird.Models;
using Microsoft.AspNetCore.Mvc;
using static LinenAndBird.Models.Hat;

namespace LinenAndBird.Controllers
{
    [Route("api/hats")] // Exposed at this endpoint
    [ApiController] // An api controller, so it returns json or xml
    public class HatsController : ControllerBase
    {
        HatRepository _repo;
        public HatsController()
        {
            _repo = new HatRepository();
        }

        [HttpGet]
        public List<Hat> GetAllHats()
        {
            return _repo.GetAll();
        }

        [HttpGet("styles/{style}")]
        public IEnumerable<Hat> GetHatsByStyle(HatStyle style)
        {
            var matches = _repo.GetByStyle(style);

            return matches;
        }

        [HttpPost]
        public void AddAHat(Hat newHat)
        {
            _repo.Add(newHat);
        }

    }
}
