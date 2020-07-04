using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ifes.lib.domain {
    public class Passenger : ApplicationUser{
        public string ReservationCode { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        
        
    }
}