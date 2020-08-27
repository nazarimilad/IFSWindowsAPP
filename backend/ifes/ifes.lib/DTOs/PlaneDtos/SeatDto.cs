using ifes.lib.domain.Planes;
using ifes.lib.DTOs.UsersDtos;
using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.PlaneDtos {
  public  class SeatDto {

        public SeatDto(Seat seat) {
            this.Id = seat.Id;
            this.Col = seat.Col;
            this.Row = seat.Row;
            this.FlightClass = seat.FlightClass;

        }
        public SeatDto() {

        }

        public Guid Id { get; set; }
        public char Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }

        public PassengerDto Passenger { get; set; }
    }
}
