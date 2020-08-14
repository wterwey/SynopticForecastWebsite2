using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SynopticForecastWebsite2.Data;
using SynopticForecastWebsite2.Models;

namespace SynopticForecastWebsite2.Pages
{
    public class SchedulingAddModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public SchedulingAddModel(ForecastWebsiteContext context)
        {
            _context = context;
        }

        public List<ForecastPeriod> ForecastPeriods { get; set; }

        public async Task OnGetAsync()
        {
            ForecastPeriods = await _context.ForecastPeriods.ToListAsync();
        }
    }
}