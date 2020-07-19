using Ifes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class LiveFlightData
    {
        public int Speed { get; private set; }
        public int Altitude { get; private set; }
        public int Temperature { get; private set; }
        public string EtaTime
        {
            get
            {
                int speed = new Random().Next(250, 254);
                int timeSeconds = (int) Math.Floor((double) FlightInfoService.Instance.FlightInfo.FlightDistance / speed);
                TimeSpan time = TimeSpan.FromSeconds(timeSeconds);
                string timeFormatted = time.ToString(@"hh\:mm\:ss\:fff");
                return timeFormatted;
            }
        }

        public LiveFlightData(int speed, int altitude, int temperature)
        {
            Speed = (int) (speed * 3.6);
            Altitude = altitude;
            Temperature = temperature;
        }
    }
}
