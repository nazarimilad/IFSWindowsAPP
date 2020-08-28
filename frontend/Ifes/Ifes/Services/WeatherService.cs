using Ifes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class WeatherService
    {
        private static readonly Lazy<WeatherService> lazy = new Lazy<WeatherService>(() => new WeatherService());

        public static WeatherService Instance { get { return lazy.Value; } }

        public Weather Weather { get; private set; }

        private WeatherService()
        {
            Weather = GetWeather().Result;
        }

        private async Task<Weather> GetWeather()
        {

            //api key:<bd981360a960a8b2629b76c91b912a2d>
            // TODO: make http request and deserialise JSON result into corresponding view model
            return new Weather(FlightInfoService.Instance.FlightInfo.Destination, DateTime.Now, 25, 0.12, 3.8);
        }
    }
}
