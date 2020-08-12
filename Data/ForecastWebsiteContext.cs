using Microsoft.EntityFrameworkCore;
using SynopticForecastWebsite2.Models;

namespace SynopticForecastWebsite2.Data
{
    public class ForecastWebsiteContext : DbContext
    {
        public ForecastWebsiteContext (DbContextOptions<ForecastWebsiteContext> options) : base(options)
        { }

        public DbSet<Forecast> Forecasts { get; set; }
        public DbSet<ForecastPeriod> ForecastPeriods { get; set; }
        public DbSet<VerifiedForecast> VerifiedForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forecast>().ToTable("Forecast");
            modelBuilder.Entity<ForecastPeriod>().ToTable("ForecastPeriod");
            modelBuilder.Entity<VerifiedForecast>().ToTable("VerifiedForecast");
        }
    }
}