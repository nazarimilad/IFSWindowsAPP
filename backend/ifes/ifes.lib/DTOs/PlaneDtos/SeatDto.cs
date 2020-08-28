using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
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
            Passenger = new PassengerSmallDto(seat.Passenger);
        }
        public SeatDto() {

        }

        public Guid Id { get; set; }
        public string Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }

        public PassengerSmallDto Passenger { get; set; }
    }

}

public class PassengerSmallDto
{

    public PassengerSmallDto(Passenger passenger)
    {
        Name = passenger?.UserName;
        Id = passenger?.Id;
    }

    public string Name { get; set; }
    public string Id { get; set; }

   

}
