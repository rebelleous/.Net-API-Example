using AlphaStellar.Models;
using AlphaStellar.Services;
using AlphaStellar.Services.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AlphaStellar
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            // ------ DB CONNECTION ------
            services.AddDbContext<AppDbContext>(
            options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
            // ------ DB CONNECTION ------

            // ------ SERVICE INJECTION ------
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IBoatService, BoatService>();
            services.AddScoped<ICarService, CarService>();
            // ------ SERVICE INJECTION ------


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AlphaStellar", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AlphaStellar v1"));
            }
            SeedData.Seed(app);
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
