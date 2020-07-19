using Ifes.ViewModels;
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

        public AirPlaneInfo AirPlaneInfo { get; private set; }
        public FlightInfo FlightInfo { get; set; }
        public LiveFlightData LiveFlightData { get; set; }

        private FlightInfoService()
        {
            AirPlaneInfo = GetAirPlaneInfo().Result;
            FlightInfo = GetFlightInfo().Result;
            LiveFlightData = GetLiveFlightData().Result;
        }

        private async Task<AirPlaneInfo> GetAirPlaneInfo()
        {
            // TODO: make http request and deserialise JSON result into corresponding view model
            return new AirPlaneInfo("F-GUGJ", 132, "Air France", "Airbus", "A318");
        }

        private async Task<FlightInfo> GetFlightInfo()
        {
            // TODO: make http request and deserialise JSON result into corresponding view model
            return new FlightInfo("Brussels", "New York", 5880_000);
        }

        public async Task<LiveFlightData> GetLiveFlightData()
        {
            // TODO: make http request and deserialise JSON result into corresponding view model
            Random rnd = new Random();
            int speed = rnd.Next(250, 254);
            int altitude = rnd.Next(11540, 11580);
            int temperature = rnd.Next(-50, -40);
            int distanceToDestination = FlightInfo.FlightDistance;
            int distanceTraveled = speed * 5;
            FlightInfo.FlightDistance -= distanceTraveled;
            int etaTimeSeconds = (int) Math.Floor((double) FlightInfo.FlightDistance / 250);
            TimeSpan etaTime = TimeSpan.FromSeconds(etaTimeSeconds);
            string etaTimeFormatted = etaTime.ToString(@"hh\:mm\:ss");
            return new LiveFlightData(speed, altitude, temperature, etaTimeFormatted);
        }
    }
}
