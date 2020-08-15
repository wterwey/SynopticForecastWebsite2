using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynopticForecastWebsite2.Models
{
    public class Forecast
    {
        //==============================================================
        // PROPERTIES
        public int ForecastID { get; set; }
        public int ForecastPeriodID { get; set; }
        public int? ForecastTime { get; set; }
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
        public string FrontalPassage { get; set; }
        public string FrontalPassageTime { get; set; }

        //==============================================================
        // ToString()

        public override string ToString()
        {
            string tempStr = "";
            tempStr += $"Forecast time: +{ForecastTime} hours\n";
            tempStr += $"Min/Max temps: {MinimumTemperature} / {MaximumTemperature}\n";
            tempStr += $"Surface temp/dew: {SurfaceTemperature} / {SurfaceDewpoint}\n";
            tempStr += $"Surface wind dir/spd: {SurfaceWindDirect} @ {SurfaceWindSpeed}\n";
            tempStr += $"Max sfc wind spd: {SurfaceMaxWindSpeed}\n";
            tempStr += $"Sea-level pressure: {SeaLevelPressure}\n";
            tempStr += $"Clouds: {CloudCover} with ceiling {CloudCeiling}\n";
            tempStr += $"Visibility category {Visibility}\n";
            tempStr += $"Observed Weather: {ObservedWeather}\n";
            tempStr += $"Precip Probability of {ProbOfPrecip}% at QPF category {PrecipCategory} of type {PrecipType}\n";
            tempStr += $"Snow accumulation category: {SnowAccumulation}\n";
            tempStr += $"Thunderstorms: {Thunderstorms}, Svr Flood: {SevereWeatherFlood}, Wind: {SevereWeatherWind}, Tornado: {SevereWeatherTornado}, Hail: {SevereWeatherHail}\n";
            tempStr += $"Front {FrontalPassage} passing at {FrontalPassageTime} UTC.\n\n";
            return tempStr;
        }


        //==============================================================
        // CONSTRUCTOR

        //public Forecast(int forecastTime, int forecastPeriodID)
        //{
        //    ForecastID = 0;
        //    ForecastPeriodID = forecastPeriodID;
        //    ForecastTime = forecastTime;
        //    MinimumTemperature = null;
        //    MaximumTemperature = null;
        //    SurfaceTemperature = null;
        //    SurfaceDewpoint = null;
        //    SurfaceWindDirect = null;
        //    SurfaceWindSpeed = null;
        //    SurfaceMaxWindSpeed = null;
        //    SeaLevelPressure = null;
        //    CloudCover = null;
        //    CloudCeiling = null;
        //    Visibility = null;
        //    ObservedWeather = null;
        //    ProbOfPrecip = null;
        //    PrecipCategory = null;
        //    PrecipType = null;
        //    SnowAccumulation = null;
        //    Thunderstorms = false;
        //    SevereWeatherFlood = false;
        //    SevereWeatherWind = false;
        //    SevereWeatherTornado = false;
        //    SevereWeatherHail = false;
        //    FrontalPassage = null;
        //    FrontalPassageTime = null;

        //}

        //public Forecast()
        //{
        //    ForecastID = 0;
        //    ForecastPeriodID = 0;
        //    ForecastTime = null;
        //    MinimumTemperature = null;
        //    MaximumTemperature = null;
        //    SurfaceTemperature = null;
        //    SurfaceDewpoint = null;
        //    SurfaceWindDirect = null;
        //    SurfaceWindSpeed = null;
        //    SurfaceMaxWindSpeed = null;
        //    SeaLevelPressure = null;
        //    CloudCover = null;
        //    CloudCeiling = null;
        //    Visibility = null;
        //    ObservedWeather = null;
        //    ProbOfPrecip = null;
        //    PrecipCategory = null;
        //    PrecipType = null;
        //    SnowAccumulation = null;
        //    Thunderstorms = false;
        //    SevereWeatherFlood = false;
        //    SevereWeatherWind = false;
        //    SevereWeatherTornado = false;
        //    SevereWeatherHail = false;
        //    FrontalPassage = null;
        //    FrontalPassageTime = null;

        //}


        //==============================================================
        // DATA ADDITION METHODS

        public void InsertForecast(List<Object> forecastParams)
        {
            this.MinimumTemperature = (int)forecastParams[0];
            this.MaximumTemperature = (int)forecastParams[1];
            this.SurfaceTemperature = (int)forecastParams[2];
            this.SurfaceDewpoint = (int)forecastParams[3];
            this.SurfaceWindDirect = (int)forecastParams[4];
            this.SurfaceWindSpeed = (int)forecastParams[5];
            this.SurfaceMaxWindSpeed = (int)forecastParams[6];
            this.SeaLevelPressure = (int)forecastParams[7];
            this.CloudCover = (string)forecastParams[8];
            this.CloudCeiling = (int)forecastParams[9];
            this.Visibility = (int)forecastParams[10];
            this.ObservedWeather = (string)forecastParams[11];
            this.ProbOfPrecip= (int)forecastParams[12];
            this.PrecipCategory = (int)forecastParams[13];
            this.PrecipType = (string)forecastParams[14];
            this.SnowAccumulation = (int)forecastParams[15];
            this.Thunderstorms = (bool)forecastParams[16];
            this.SevereWeatherFlood = (bool)forecastParams[17];
            this.SevereWeatherWind = (bool)forecastParams[18];
            this.SevereWeatherTornado = (bool)forecastParams[19];
            this.SevereWeatherHail = (bool)forecastParams[20];
            this.FrontalPassage = (string)forecastParams[21];
            this.FrontalPassageTime = (string)forecastParams[22];
        }


    }
}
