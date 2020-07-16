using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class FlightInfoService
    {
        private static readonly Lazy<FlightInfoService> lazy = new Lazy<FlightInfoService>(() => new FlightInfoService());

        public static FlightInfoService Instance { get { return lazy.Value; } }

        private FlightInfoService()
        {
        }
    }
}
