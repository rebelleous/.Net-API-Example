using AlphaStellar.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaStellar.Services.Helpers
{
    public class SeedData
    {

        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<AppDbContext>();
            context.Database.Migrate();

            if (context.Set<Car>().Count() == 0)
            {
                context.Set<Car>().AddRange(
                new List<Car>()
                {
                         new Car() { Color="red",HeadLights=true,Wheel=4 },
                         new Car() { Color="blue",HeadLights=false,Wheel=2 },
                         new Car() { Color="black",HeadLights=false,Wheel=4 },
                         new Car() { Color="white",HeadLights=true,Wheel=2 },
                         new Car() { Color="white",HeadLights=false,Wheel=3 },
                         new Car() { Color="black",HeadLights=true,Wheel=4 },
                         new Car() { Color="blue",HeadLights=true,Wheel=3 },
                         new Car() { Color="red",HeadLights=false,Wheel=1 },
                }
                );
            }
            if (context.Set<Bus>().Count() == 0)
            {
                context.Set<Bus>().AddRange(
                    new List<Bus>()
                    {
                        new Bus(){Color="red"},
                        new Bus(){Color="blue"},
                        new Bus(){Color="black"},
                        new Bus(){Color="white"},
                        new Bus(){Color="white"},
                        new Bus(){Color="black"},
                        new Bus(){Color="blue"},
                        new Bus(){Color="red"},
                    }
                    );
            }
            if (context.Set<Boat>().Count() == 0)
            {
                context.Set<Boat>().AddRange(
                    new List<Boat>()
                    {
                        new Boat(){Color="red"},
                        new Boat(){Color="blue"},
                        new Boat(){Color="black"},
                        new Boat(){Color="white"},
                        new Boat(){Color="white"},
                        new Boat(){Color="black"},
                        new Boat(){Color="blue"},
                        new Boat(){Color="red"},
                    }
                    );
            }

            context.SaveChanges();

        }
    }
}
