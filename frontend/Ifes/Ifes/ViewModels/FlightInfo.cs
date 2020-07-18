using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class FlightInfo
    {
        public string Origine { get; private set; }
        public string Destination { get; private set; }
        // flight time in seconds
        public int FlightTime { get; private set; }

        public FlightInfo(string origine, string destination, int flightTime)
        {
            Origine = origine;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}
