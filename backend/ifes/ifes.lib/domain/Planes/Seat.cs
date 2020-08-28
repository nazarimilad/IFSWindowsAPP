using System;
using ifes.lib.domain.Users;
using ifes.lib.Enum;

namespace ifes.lib.domain.Planes {
    public class Seat {
        public Guid Id { get; set; }
        public string Col { get; set; }
        public int Row { get; set; }
        public Plane Plane{ get; set; }
        public FlightClass FlightClass { get; set; }
        public  Passenger Passenger { get; set; }


        public Seat(string col, int row, FlightClass flightClass) {
            Col = col;
            Row = row;
            FlightClass = flightClass;
        }

    }
}