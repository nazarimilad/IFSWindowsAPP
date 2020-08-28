using Ifes.Dto;
using Ifes.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class WeatherService
    {
        private static readonly Lazy<WeatherService> lazy = new Lazy<WeatherService>(() => new WeatherService());

        public static WeatherService Instance { get { return lazy.Value; } }

        public ViewModels.Weather Weather { get; private set; }

        private WeatherService()
        {
          
        }

        public async Task<ViewModels.Weather> GetWeather()
        {

            //api key:<bd981360a960a8b2629b76c91b912a2d>
            var client = new HttpClient();
            var externResultStr = await client.GetStringAsync( new Uri("http://api.openweathermap.org/data/2.5/weather?id=5128581&appid=bd981360a960a8b2629b76c91b912a2d", UriKind.Absolute));
            var externResult = JsonConvert.DeserializeObject<ExternWeather>(externResultStr);
            //http://api.openweathermap.org/data/2.5/weather?id=5128581&appid=bd981360a960a8b2629b76c91b912a2d
            // TODO: make http request and deserialise JSON result into corresponding view model
            this.Weather = new ViewModels.Weather(externResult);
            return new ViewModels.Weather(externResult);
        }
    }
}
