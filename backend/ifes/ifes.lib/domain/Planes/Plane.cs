using System;
using System.Collections.Generic;
using System.Linq;
using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Users;
using ifes.lib.Enum;

namespace ifes.lib.domain.Planes {
    public class Plane {
        public Guid Id { get; set; }
        public string TailNumber { get; set; }
        public string Type { get; set; }
        public IEnumerable<Seat> Seats { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<CabinCrew> CabinCrew { get; set; }

        public  Catalog Catalog { get; set; }

        public Plane() { }

        public Plane(FlightInfo flightInfo , Catalog catalog) {
            Orders = new List<Order>(); 
        }
        public void SwitchUserSeats(Passenger firstUser, Passenger secondUser) {
            var seat1 = FindSeatOfPassenger(firstUser);
            var seat2 = FindSeatOfPassenger(secondUser);
            if (seat1 == null || seat2 == null) throw new ArgumentException("One of the users was not found");
            seat1.Passenger = secondUser;
            seat2.Passenger = firstUser;
        }

        public void AddSeat(char col, int row, FlightClass flightClass) {
            if (Seats == null) {
                Seats = new List<Seat>();
            }

            Seats.Append(new Seat(col, row, flightClass));
        }

        public void AssingPassengerToSeat(Passenger passenger, char column, int row) {
           var seat = Seats.FirstOrDefault(p => p.Col == column && p.Row == row);
           if (seat == null) {
               throw  new ArgumentException("seat not found");
           }
           seat.Passenger = passenger;
        }

        public void PutCrewManToWork(CabinCrew cabinCrew) {
            if (CabinCrew == null) {
                CabinCrew = new List<CabinCrew>();
            }
            CabinCrew.Append(cabinCrew);
        }
        
        
        public IEnumerable<Order> GetOrdersInProgress() => GetOrdersOfStatus(OrderStatus.InProgress);
        private Seat FindSeatOfPassenger(Passenger user) => Seats.FirstOrDefault(p => p.Passenger.Id == user.Id);
        private IEnumerable<Order> GetOrdersOfStatus(OrderStatus status) => Orders.Where(p => p.Status == status);
    }
}