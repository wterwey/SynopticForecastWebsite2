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
    public class ForecastsModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public ForecastsModel(ForecastWebsiteContext context)
        {
            _context = context;
        }

        public List<ForecastPeriod> ForecastPeriods { get; set; }
        public List<Forecast> PersonalForecasts { get; set; }
        public ForecastPeriod CurrentPeriod { get; set; }
        [BindProperty]
        public int SelectedForePeriodID { get; set; }

        public async Task<IActionResult> OnGetAsync(int? FPid)
        {
            ForecastPeriods = await _context.ForecastPeriods.ToListAsync();
            ForecastPeriods.Reverse();

            if (FPid != null)
            {
                CurrentPeriod = await _context.ForecastPeriods.FindAsync(FPid);
                PersonalForecasts = await _context.Forecasts.Where(x => x.ForecastPeriodID == FPid).ToListAsync();
                SelectedForePeriodID = (int)FPid;

                if (PersonalForecasts.Count == 0 || PersonalForecasts == null)
                {
                    Forecast tempForecast = new Forecast() 
                    { ForecastPeriod = CurrentPeriod,
                        ForecastTime = 12,
                        ForecastPeriodID = (int)FPid
                    };
                    _context.Forecasts.Add(tempForecast);

                    tempForecast = new Forecast()
                    {
                        ForecastPeriod = CurrentPeriod,
                        ForecastTime = 24,
                        ForecastPeriodID = (int)FPid
                    };
                    _context.Forecasts.Add(tempForecast);

                    tempForecast = new Forecast()
                    {
                        ForecastPeriod = CurrentPeriod,
                        ForecastTime = 36,
                        ForecastPeriodID = (int)FPid
                    };
                    _context.Forecasts.Add(tempForecast);

                    tempForecast = new Forecast()
                    {
                        ForecastPeriod = CurrentPeriod,
                        ForecastTime = 48,
                        ForecastPeriodID = (int)FPid
                    };
                    _context.Forecasts.Add(tempForecast);

                    tempForecast = new Forecast()
                    {
                        ForecastPeriod = CurrentPeriod,
                        ForecastTime = 60,
                        ForecastPeriodID = (int)FPid
                    };
                    _context.Forecasts.Add(tempForecast);

                    await _context.SaveChangesAsync();

                    PersonalForecasts = await _context.Forecasts.Where(x => x.ForecastPeriodID == FPid).ToListAsync();
                }
            }

            return Page();

        }

        public IActionResult OnPost(int? FPid)
        {

            _ = SelectedForePeriodID;
            return RedirectToPage($"Forecasts", new { FPid = SelectedForePeriodID });

        }
    }
}