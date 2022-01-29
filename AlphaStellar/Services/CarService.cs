using AlphaStellar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Services
{
    public class CarService : GenericService<Car>, ICarService
    {
        public CarService(AppDbContext context) : base(context)
        {

        }

        public async Task<string> TurnCarHeadLightsByIdAsync(int id)
        {
            try
            {
                var car = await GetById(id);

                if (car.HeadLights == false)
                {
                    car.HeadLights = true;
                }
                else
                {
                    car.HeadLights = false;
                }
                await Update(id, car);
                return await Task.FromResult("HeadLights turned on/off.");
            }
            catch (Exception)
            {
                return await Task.FromResult("HeadLights didn't work.");
            }

        }
    }
}
