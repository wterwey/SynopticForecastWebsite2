using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SynopticForecastWebsite2.Pages
{
    public class ForecastEditModel : PageModel
    {
        public int? MinimumTemperature { get; set; }
        public int? MaximumTemperature { get; set; }
        public int? SurfaceTemperature { get; set; }
        public int? SurfaceDewpoint { get; set; }
        public int? SurfaceWindDirect { get; set; }
        public int? SurfaceWindSpeed { get; set; }
        public int? SurfaceMaxWindSpeed { get; set; }
        public int? SeaLevelPressure { get; set; }
        public string CloudCover { get; set; }
        public int? CloudCeiling { get; set; }
        public int? Visibility { get; set; }
        public string ObservedWeather { get; set; }
        public int? ProbOfPrecip { get; set; }
        public int? PrecipCategory { get; set; }
        public string PrecipType { get; set; }
        public int? SnowAccumulation { get; set; }
        public bool Thunderstorms { get; set; }
        public bool SevereWeatherFlood { get; set; }
        public bool SevereWeatherWind { get; set; }
        public bool SevereWeatherTornado { get; set; }
        public bool SevereWeatherHail { get; set; }
        // FrontalPassage will list either the type of frontal passage (warm, cold, etc.) or Null for none.
        // FrontalPassageTime will list the UTC hour of the frontal passage or -999 for none.
        public List<string> FrontalPassage { get; set; }
        public List<int?> FrontalPassageTime { get; set; }

        public void OnGet()
        {

        }
    }
}