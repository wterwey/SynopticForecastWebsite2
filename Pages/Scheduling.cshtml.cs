﻿using System;
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
    public class SchedulingModel : PageModel
    {
        private readonly ForecastWebsiteContext _context;

        public SchedulingModel(ForecastWebsiteContext context)
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