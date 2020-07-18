using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class LiveFlightInfo
    {
        public int Speed { get; private set; }
        public int Altitude { get; private set; }
        public int Temperature { get; private set; }

        public LiveFlightInfo(int speed, int altitude, int temperature)
        {
            Speed = speed;
            Altitude = altitude;
            Temperature = temperature;
        }
    }
}
