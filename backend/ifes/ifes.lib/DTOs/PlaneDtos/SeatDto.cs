using ifes.lib.DTOs.UsersDtos;
using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.PlaneDtos {
  public  class SeatDto {
        public Guid Id { get; set; }
        public char Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }

        public PassengerDto Passenger { get; set; }
    }
}
