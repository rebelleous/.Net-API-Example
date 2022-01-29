using AlphaStellar.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("{color}")]
        public IActionResult SelectCarByColor(string color)
        {
            var cars = _carService.GetAllByColor(color);
            if (cars.Count() > 0)
            {
                return Ok(cars);
            }
            else
            {
                return NotFound("Car not found.");
            }
        }

        [HttpDelete("{ID}")]
        public async Task<IActionResult> DeleteCarByID(int ID)
        {
            await _carService.Delete(ID);
            return Ok("Deleted");
            
        }

        [HttpPatch("{ID}")]
        public async Task<IActionResult> TurnHeadlightsByID(int ID)
        {
            return Ok(await _carService.TurnCarHeadLightsByIdAsync(ID));
        }

    }
}
