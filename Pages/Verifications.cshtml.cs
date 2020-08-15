using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynopticForecastWebsite2.Models;
using SynopticForecastWebsite2.Data;
using Microsoft.EntityFrameworkCore;

namespace SynopticForecastWebsite2.Pages
{
    public class VerificationsModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public VerificationsModel(ForecastWebsiteContext context)
        {
            _context = context;
        }

        public List<ForecastPeriod> ForecastPeriods { get; set; }
        public List<VerifiedForecast> AllVerified { get; set; }
        public List<VerifiedForecast> CurrentVerified { get; set; }
        public int CurrVeriCount { get; set; }

        public async Task OnGetAsync()
        {
            ForecastPeriods = await _context.ForecastPeriods.ToListAsync();
            ForecastPeriods.Reverse();
            AllVerified = await _context.VerifiedForecasts.ToListAsync();
        }
    }
}