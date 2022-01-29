using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }

        DbSet<Boat> Boat { get; set; }
        DbSet<Bus> Bus { get; set; }
        DbSet<Car> Car { get; set; }
    }
}
