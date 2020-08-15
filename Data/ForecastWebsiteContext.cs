using Microsoft.EntityFrameworkCore;
using SynopticForecastWebsite2.Models;
using System.Security.Cryptography.X509Certificates;

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
            modelBuilder.Entity<ForecastPeriod>()
                .HasMany(x => x.VerifiedForecasts)
                .WithOne(y => y.ForecastPeriod);

            modelBuilder.Entity<VerifiedForecast>()
                .HasOne(x => x.ForecastPeriod)
                .WithMany(y => y.VerifiedForecasts);

            modelBuilder.Entity<Forecast>().ToTable("Forecast");
            modelBuilder.Entity<ForecastPeriod>().ToTable("ForecastPeriod");
            modelBuilder.Entity<VerifiedForecast>().ToTable("VerifiedForecast");
        }
    }
}