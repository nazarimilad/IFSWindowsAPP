using System;

namespace ifes.lib.domain.Planes {
    public class FlightInfo {
        public Guid Id { get; set; }
        public Airport From { get; set; }
        public Airport To { get; set; }

        public DateTime ExpectedDeparture { get; set; }
        public DateTime ExpectedArrival { get; set; }

        public FlightInfo(Airport from, Airport to, DateTime expectedDeparture, DateTime expectedArrival) {
            From = from;
            To = to;
            ExpectedDeparture = expectedDeparture;
            ExpectedArrival = expectedArrival;
        }
        public FlightInfo() {

        }
    }
}