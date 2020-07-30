using System;
using ifes.lib.domain.Users;
using ifes.lib.Enum;

namespace ifes.lib.domain.Planes {
    public class Seat {
        public Guid Id { get; set; }
        public char Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }

        public Passenger Passenger { get; set; }

        public Seat(char col, int row, FlightClass flightClass) {
            Col = col;
            Row = row;
            FlightClass = flightClass;
        }
        
    }
}