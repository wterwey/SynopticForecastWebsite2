using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynopticForecastWebsite2.Models
{
    public class ForecastPeriod
    {
        public int ForecastPeriodID { get; set; }
        public int? ForecastTime1 { get; set; }
        public int? ForecastTime2 { get; set; }
        public int? ForecastTime3 { get; set; }
        public int? ForecastTime4 { get; set; }
        public int? ForecastTime5 { get; set; }
        public DateTime ForecastTimeUTC1 { get; set; }
        public DateTime ForecastTimeUTC2 { get; set; }
        public DateTime ForecastTimeUTC3 { get; set; }
        public DateTime ForecastTimeUTC4 { get; set; }
        public DateTime ForecastTimeUTC5 { get; set; }
        public int? VerifiedForecast1 { get; set; }
        public int? VerifiedForecast2 { get; set; }
        public int? VerifiedForecast3 { get; set; }
        public int? VerifiedForecast4 { get; set; }
        public int? VerifiedForecast5 { get; set; }
        public string City { get; set; }
        public string CityID { get; set; }
        public DateTime StartingTimeUTC { get; set; }
        public DateTime OpenTimeUTC { get; set; }
        public DateTime ClosedTimeUTC { get; set; }


        public ForecastPeriod()
        {
            ForecastPeriodID = 0;
            ForecastTime1 = null;
            ForecastTime2 = null;
            ForecastTime3 = null;
            ForecastTime4 = null;
            ForecastTime5 = null;
            ForecastTimeUTC1 = new DateTime(1901, 1, 1, 12, 0, 0);
            ForecastTimeUTC2 = new DateTime(1901, 1, 1, 12, 0, 0);
            ForecastTimeUTC3 = new DateTime(1901, 1, 1, 12, 0, 0);
            ForecastTimeUTC4 = new DateTime(1901, 1, 1, 12, 0, 0);
            ForecastTimeUTC5 = new DateTime(1901, 1, 1, 12, 0, 0);
            VerifiedForecast1 = null;
            VerifiedForecast2 = null;
            VerifiedForecast3 = null;
            VerifiedForecast4 = null;
            VerifiedForecast5 = null;
            City = "";
            CityID = "";
            StartingTimeUTC = new DateTime(1901, 1, 1);
            OpenTimeUTC = new DateTime(1901, 1, 1);
            ClosedTimeUTC = new DateTime(1901, 1, 1);
        }

    }


}
