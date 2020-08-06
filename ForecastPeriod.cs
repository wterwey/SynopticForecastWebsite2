using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynopticForecastWebsite2
{
    public class ForecastPeriod
    {
        public int ForecastPeriodID { get; set; }
        public List<int?> ForecastTimes { get; set; }
        public List<DateTime> ForecastTimesUTC { get; set; }
        public List<VerifiedForecast> VerifiedForecasts { get; set; }
        public string City { get; set; }
        public string CityID { get; set; }
        public DateTime StartingTimeUTC { get; set; }
        public DateTime OpenTimeUTC { get; set; }
        public DateTime ClosedTimeUTC { get; set; }


    }
}
