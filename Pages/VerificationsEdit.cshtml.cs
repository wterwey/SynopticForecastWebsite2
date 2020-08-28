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
    public class VerificationsEditModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public VerificationsEditModel(ForecastWebsiteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VerifiedForecast VFEdit { get; set; }
        
        [BindProperty]
        public ForecastPeriod VF_ForePeriod { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? VFid)
        {
            if (VFid == null)
            {
                return NotFound();
            }
            else
            {
                VFEdit = await _context.VerifiedForecasts.FindAsync(VFid);

                if (VFEdit == null)
                {
                    return NotFound();
                }
                else
                {
                    VF_ForePeriod = await _context.ForecastPeriods.FindAsync(VFEdit.ForecastPeriodID);
                }
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? VFid)
        {
            if (!ModelState.IsValid) { return Page(); }

            if (VFid == null)
            {
                return NotFound();
            }
            else
            {
                _context.Attach(VFEdit).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("Verifications");
        }
    }
}