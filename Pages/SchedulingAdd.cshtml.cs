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

        [BindProperty]
        public ForecastPeriod FPAdd { get; set; }

        public void OnGet()
        {
            FPAdd = new ForecastPeriod() { VerifiedForecasts = new List<VerifiedForecast>() };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            FPAdd.ForecastTime1 = 12;
            FPAdd.ForecastTime2 = 24;
            FPAdd.ForecastTime3 = 36;
            FPAdd.ForecastTime4 = 48;
            FPAdd.ForecastTime5 = 60;

            FPAdd.ForecastTimeUTC1 = FPAdd.StartingTimeUTC.AddHours((double) FPAdd.ForecastTime1);
            FPAdd.ForecastTimeUTC2 = FPAdd.StartingTimeUTC.AddHours((double) FPAdd.ForecastTime2);
            FPAdd.ForecastTimeUTC3 = FPAdd.StartingTimeUTC.AddHours((double) FPAdd.ForecastTime3);
            FPAdd.ForecastTimeUTC4 = FPAdd.StartingTimeUTC.AddHours((double) FPAdd.ForecastTime4);
            FPAdd.ForecastTimeUTC5 = FPAdd.StartingTimeUTC.AddHours((double) FPAdd.ForecastTime5);

            await _context.SaveChangesAsync();

            FPAdd.VerifiedForecasts = new List<VerifiedForecast>();

            FPAdd.VerifiedForecasts.Add(new VerifiedForecast() { ForecastTime = 12 });
            FPAdd.VerifiedForecasts.Add(new VerifiedForecast() { ForecastTime = 24 });
            FPAdd.VerifiedForecasts.Add(new VerifiedForecast() { ForecastTime = 36 });
            FPAdd.VerifiedForecasts.Add(new VerifiedForecast() { ForecastTime = 48 });
            FPAdd.VerifiedForecasts.Add(new VerifiedForecast() { ForecastTime = 60 });

            //FPAdd.VerifiedForecasts.Add(new VerifiedForecast(12, FPAdd));
            //FPAdd.VerifiedForecasts.Add(new VerifiedForecast(24, FPAdd));
            //FPAdd.VerifiedForecasts.Add(new VerifiedForecast(36, FPAdd));
            //FPAdd.VerifiedForecasts.Add(new VerifiedForecast(48, FPAdd));
            //FPAdd.VerifiedForecasts.Add(new VerifiedForecast(60, FPAdd));
            //FPAdd.VerifiedForecast2 = new VerifiedForecast(24, FPAdd);
            //FPAdd.VerifiedForecast3 = new VerifiedForecast(36, FPAdd);
            //FPAdd.VerifiedForecast4 = new VerifiedForecast(48, FPAdd);
            //FPAdd.VerifiedForecast5 = new VerifiedForecast(60, FPAdd);

            _context.ForecastPeriods.Add(FPAdd);

            await _context.SaveChangesAsync();

            return RedirectToPage("Scheduling");
        }
    }
}