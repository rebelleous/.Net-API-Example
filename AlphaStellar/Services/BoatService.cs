using AlphaStellar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Services
{
    public class BoatService : GenericService<Boat>, IBoatService
    {
        public BoatService(AppDbContext context) : base(context)
        {
        }
    }
}
