using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Passenger
    {
        //public string FirstName { get; private set; }
        //public string LastName { get; private set; }
        public string UserName { get; set; }
        public string Email { get; private set; }
        public string ReservationNumber { get; private set; }
        public Guid PlaneId { get; set; }
        public string Token { get; set; }
        [JsonProperty("seat")]
        public Seat Seat { get; private set; }

        public IEnumerable<Order> Orders { get; set; }


        public Passenger(string userName, string email, Seat seat, string reservationNumber)
        {
            UserName = userName;
            Email = email;
            Seat = seat;
            ReservationNumber = reservationNumber;
        }

        public Passenger() {
        }

        public override string ToString()
        {
            return $"{UserName}";
        }
    }
}
