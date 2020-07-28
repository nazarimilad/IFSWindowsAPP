using System;
using System.Collections.Generic;
using ifes.lib.domain.Catalogs;
using Microsoft.AspNetCore.Identity;

namespace ifes.lib.domain.Users {
    public class Passenger : ApplicationUser{
        public string ReservationCode { get; set; }
        public IEnumerable<Order> Orders { get; set; }


    }
}