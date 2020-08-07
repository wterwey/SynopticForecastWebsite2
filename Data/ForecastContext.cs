using Microsoft.EntityFrameworkCore;
using SynopticForecastWebsite2.Models;

namespace SynopticForecastWebsite2.Data
{
    public class ForecastContext : DbContext
    {
        public ForecastContext (DbContextOptions<ForecastContext> options) : base(options)
        { }

        public DbSet<Forecast> Forecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forecast>().ToTable("Forecast");
        }
    }
}