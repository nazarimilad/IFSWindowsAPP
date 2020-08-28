using ifes.lib.domain.Users;
using ifes.lib.DTOs.CatalogDtos;
using ifes.lib.DTOs.PlaneDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.UsersDtos {
    public class PassengerDto {


        public PassengerDto()
        {

        }

        public PassengerDto(Passenger passenger, Guid planeId)
        {
            UserName = passenger.UserName;
            Id = passenger.Id;
            ReservationNumber = passenger.ReservationCode;
            PlaneId = planeId;
            if (passenger.Seat!= null)
            {
                Seat = new SeatDto(passenger?.Seat);
            }
        }

        public string UserName { get; set; }
        public string Id { get; set; }
        public string Token{ get; set; }
        public Guid PlaneId { get; set; }
        public SeatDto Seat { get; set; }
        public string ReservationNumber { get; set; }
        //public IEnumerable<OrderDto> Orders { get; set; }

    }
}
