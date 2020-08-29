using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.domain.Users
{
    public class ReservationGroup
    {
        public Guid Id { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}
