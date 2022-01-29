using AlphaStellar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Services
{
   public interface ICarService : IGenericService<Car>
    {
        Task<string> TurnCarHeadLightsByIdAsync(int id);

    }
}
