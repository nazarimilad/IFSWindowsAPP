using System;
using System.Collections.Generic;
using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using Microsoft.AspNetCore.Identity;

namespace ifes.lib.domain.Users {
    public class Passenger : ApplicationUser {
        public string ReservationCode { get; set; }
        public  Seat Seat { get; set; }
        public List<Order> Orders { get; set; }

        public ReservationGroup ReservationGroup { get; set; }


        public Passenger() {

        }

        public void AddOrder(Order order) {
            if (Orders == null) Orders = new List<Order>();
            Orders.Add(order);
        }
    }
}