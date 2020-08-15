using SynopticForecastWebsite2.Data;
using SynopticForecastWebsite2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SynopticForecastWebsite2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ForecastWebsiteContext context)
        {
            context.Database.EnsureCreated();

            if (context.Forecasts.Any() && context.VerifiedForecasts.Any() && context.ForecastPeriods.Any())
            {
                return;
            }

            Forecast fore1 = new Forecast
            {
                ForecastID = 0,
                ForecastTime = null,
                MinimumTemperature = null,
                MaximumTemperature = null,
                SurfaceTemperature = null,
                SurfaceDewpoint = null,
                SurfaceWindDirect = null,
                SurfaceWindSpeed = null,
                SurfaceMaxWindSpeed = null,
                SeaLevelPressure = null,
                CloudCover = null,
                CloudCeiling = null,
                Visibility = null,
                ObservedWeather = null,
                ProbOfPrecip = null,
                PrecipCategory = null,
                PrecipType = null,
                SnowAccumulation = null,
                Thunderstorms = false,
                SevereWeatherFlood = false,
                SevereWeatherWind = false,
                SevereWeatherTornado = false,
                SevereWeatherHail = false,
                FrontalPassage = null,
                FrontalPassageTime = null
            };
            context.Forecasts.Add(fore1);
            context.SaveChanges();

            ForecastPeriod forPer = new ForecastPeriod
            {
                ForecastTime1 = null,
                ForecastTime2 = null,
                ForecastTime3 = null,
                ForecastTime4 = null,
                ForecastTime5 = null,
                ForecastTimeUTC1 = new DateTime(1901, 1, 1, 12, 0, 0),
                ForecastTimeUTC2 = new DateTime(1901, 1, 1, 12, 0, 0),
                ForecastTimeUTC3 = new DateTime(1901, 1, 1, 12, 0, 0),
                ForecastTimeUTC4 = new DateTime(1901, 1, 1, 12, 0, 0),
                ForecastTimeUTC5 = new DateTime(1901, 1, 1, 12, 0, 0),
                //VerifiedForecast1 = null,
                //VerifiedForecast2 = null,
                //VerifiedForecast3 = null,
                //VerifiedForecast4 = null,
                //VerifiedForecast5 = null,
                VerifiedForecasts = new List<VerifiedForecast>(),
                City = "",
                CityID = "",
                StartingTimeUTC = new DateTime(1901, 1, 1),
                OpenTimeUTC = new DateTime(1901, 1, 1),
                ClosedTimeUTC = new DateTime(1901, 1, 1)
            };
            context.ForecastPeriods.Add(forPer);
            context.SaveChanges();

            VerifiedForecast vfore1 = new VerifiedForecast() { ForecastPeriod = forPer };
            context.VerifiedForecasts.Add(vfore1);
            context.SaveChanges();


        }
    }

}