using Microsoft.EntityFrameworkCore;
using SynopticForecastWebsite2.Models;

namespace SynopticForecastWebsite2.Data
{
    public class VerifiedForecastContext : DbContext
    {
        public VerifiedForecastContext (DbContextOptions<VerifiedForecastContext> options) : base(options)
        { }

        public DbSet<VerifiedForecast> VerifiedForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VerifiedForecast>().ToTable("VerifiedForecast");
        }
    }
}