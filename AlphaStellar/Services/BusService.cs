using AlphaStellar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Services
{
    public class BusService : GenericService<Bus>, IBusService
    {
        public BusService(AppDbContext context) : base(context)
        {
        }

    }
}
