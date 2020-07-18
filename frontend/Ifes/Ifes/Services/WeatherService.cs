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

        private WeatherService()
        {
        }
    }
}
