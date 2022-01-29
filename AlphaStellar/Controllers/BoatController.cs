using AlphaStellar.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("{color}")]
        public IActionResult SelectBoatByColor(string color)
        {
            var boats = _boatService.GetAllByColor(color);
            if (boats.Count() > 0)
            {
                return Ok(boats);
            }
            else
            {
                return NotFound("Boat not found.");
            }
        }
    }
}
