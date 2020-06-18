using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperEnvironmentExam2020.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using DeveloperEnvironmentExam2020.Models;

namespace DeveloperEnvironmentExam2020
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ///<summary>
            /// Her sætter vi projektet op, så at den gør brug af vores context klasser,
            /// sammen med en 'InMemoryDatabase' der holder på vores data, når projektet bliver kørt.
            ///</summary>

            services.AddDbContext<CategoryContext>(opt => opt.UseInMemoryDatabase("Rema1000"));
            services.AddDbContext<ProductContext>(opt => opt.UseInMemoryDatabase("Rema1000"));
            services.AddControllers();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
