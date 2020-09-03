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
    public class ForecastEditModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public ForecastEditModel(ForecastWebsiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Forecast CurrentForecast { get; set; }
        
        [BindProperty]
        public ForecastPeriod CurrentFP { get; set; }


        public async Task<IActionResult> OnGetAsync(int? ForID)
        {
            if (ForID == null)
            {
                return NotFound();
            }
            else
            {
                CurrentForecast = await _context.Forecasts.FindAsync(ForID);

                if (CurrentForecast == null)
                {
                    return NotFound();
                }
                else 
                {
                    CurrentFP = await _context.ForecastPeriods.FindAsync(CurrentForecast.ForecastPeriodID);
                }
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int? ForID)
        {
            if (!ModelState.IsValid) { return Page(); }
            
            if (ForID == null)
            {
                return NotFound();
            }
            else
            {
                _context.Attach(CurrentForecast).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("Forecasts");
        }

    }
}