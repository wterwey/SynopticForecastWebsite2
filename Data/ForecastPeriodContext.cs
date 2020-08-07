using Microsoft.EntityFrameworkCore;
using SynopticForecastWebsite2.Models;

namespace SynopticForecastWebsite2.Data
{
    public class ForecastPeriodContext : DbContext
    {
        public ForecastPeriodContext (DbContextOptions<ForecastPeriodContext> options) : base(options)
        { }

        public DbSet<ForecastPeriod> ForecastPeriods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForecastPeriod>().ToTable("ForecastPeriod");
        }
    }
}