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
        // flight distance in meters
        public int FlightDistance { get; set; }
        public int DistanceToDestination { get; private set; }

        public FlightInfo(string origine, string destination, int flightDistance)
        {
            Origine = origine;
            Destination = destination;
            FlightDistance = flightDistance;
            DistanceToDestination = flightDistance;
        }
    }
}
