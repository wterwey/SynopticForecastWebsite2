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
    public class SchedulingEditModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public SchedulingEditModel(ForecastWebsiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ForecastPeriod FPEdit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? FPid)
        {
            if (FPid == null)
            {
                return NotFound();
            }
            else
            {
                FPEdit = await _context.ForecastPeriods.FindAsync(FPid);

                if (FPEdit == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? FPid)
        {
            if (!ModelState.IsValid) { return Page(); }

            if (FPid == null)
            {
                return NotFound();
            }
            else
            {
                FPEdit.ForecastTimeUTC1 = FPEdit.StartingTimeUTC.AddHours((double)FPEdit.ForecastTime1);
                FPEdit.ForecastTimeUTC2 = FPEdit.StartingTimeUTC.AddHours((double)FPEdit.ForecastTime2);
                FPEdit.ForecastTimeUTC3 = FPEdit.StartingTimeUTC.AddHours((double)FPEdit.ForecastTime3);
                FPEdit.ForecastTimeUTC4 = FPEdit.StartingTimeUTC.AddHours((double)FPEdit.ForecastTime4);
                FPEdit.ForecastTimeUTC5 = FPEdit.StartingTimeUTC.AddHours((double)FPEdit.ForecastTime5);

                //-------------------------------------------
                // Change the VerFor and For associated with this ForPer???
                //-------------------------------------------


                _context.Attach(FPEdit).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("Scheduling");
        }

    }
}