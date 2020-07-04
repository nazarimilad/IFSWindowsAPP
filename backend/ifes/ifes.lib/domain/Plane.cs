using System;
using System.Collections.Generic;
using System.Linq;
using ifes.lib.Enum;

namespace ifes.lib.domain {
    public class Plane {
        public Guid Id { get; set; }
        public string TailNumber { get; set; }


        public IEnumerable<Seat> Seats { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<CabinCrew> CabinCrew { get; set; }

        public void SwitchUserSeats(Passenger firstUser, Passenger secondUser) {
            var seat1 = FindSeatOfPassenger(firstUser);
            var seat2 = FindSeatOfPassenger(secondUser);
            if (seat1 == null || seat2 == null) throw new ArgumentException("One of the users was not found");
            seat1.Passenger = secondUser;
            seat2.Passenger = firstUser;
        }

        public IEnumerable<Order> GetOrdersInProgress() => GetOrdersOfStatus(OrderStatus.InProgress);
        private Seat FindSeatOfPassenger(Passenger user) => Seats.FirstOrDefault(p => p.Passenger.Id == user.Id);
        private IEnumerable<Order> GetOrdersOfStatus(OrderStatus status) => Orders.Where(p => p.Status == status);
    }
}