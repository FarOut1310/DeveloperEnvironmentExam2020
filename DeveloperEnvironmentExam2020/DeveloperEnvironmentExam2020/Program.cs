using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperEnvironmentExam2020.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DeveloperEnvironmentExam2020
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.AddCategories(services);
                    SeedData.AddProducts(services);
                }
                catch (Exception ex)
                {
                    var errLog = services.GetRequiredService<ILogger<Program>>();
                    errLog.LogError(ex, "Error seeding the Database");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
