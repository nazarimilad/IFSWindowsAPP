using Ifes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Weather
    {
        public string Location { get; private set; }
        public DateTime DateTime { get; private set; }
        public int Temperature { get; private set; }
        // probability of precipitation
        public double Precipitation { get; private set; }
        public int WindSpeed { get; private set; }
        public string Description { get; set; }
        public Weather(string location, DateTime dateTime, int temperature, double precipitation, double windSpeed)
        {
            Location = location;
            DateTime = dateTime;
            Temperature = temperature;
            Precipitation = precipitation * 100;
            WindSpeed = (int)(windSpeed * 3.6);
        }
        public Weather(ExternWeather externWeather)
        {
            Location = externWeather.Name;
            DateTime = DateTime.Now;
            Temperature = ConvertToCelcius(externWeather.Main.Temp);
            Precipitation = ConvertToCelcius(externWeather.Main.FeelsLike);
            WindSpeed = (int)Math.Round(externWeather.Wind.Speed * 3.6);
            Description = externWeather.Weather[0]?.Description;
        }

        private int ConvertToCelcius(double value)
        {
            return (int)Math.Round(value - 273.15);
        }
    }
}
