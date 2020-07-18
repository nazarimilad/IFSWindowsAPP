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

        public LiveFlightData(int speed, int altitude, int temperature)
        {
            Speed = speed;
            Altitude = altitude;
            Temperature = temperature;
        }
    }
}
