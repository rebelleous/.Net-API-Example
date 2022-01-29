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
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("{color}")]
        public IActionResult SelectBusByColor(string color)
        {
            var busses =  _busService.GetAllByColor(color);
            if (busses.Count() > 0)
            {
                return Ok(busses);
            }
            else
            {
                return NotFound("Bus not found.");
            }
        }
    }
}
