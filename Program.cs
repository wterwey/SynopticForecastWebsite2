using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using SynopticForecastWebsite2.Data;


namespace SynopticForecastWebsite2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            CreateDbIfNotExists(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var forecastContext = services.GetRequiredService<ForecastContext>();
                forecastContext.Database.EnsureCreated();
                var forecastPeriodContext = services.GetRequiredService<ForecastPeriodContext>();
                forecastPeriodContext.Database.EnsureCreated();
                var verifiedForecastContext = services.GetRequiredService<VerifiedForecastContext>();
                verifiedForecastContext.Database.EnsureCreated();
            }
        }
    }
}
