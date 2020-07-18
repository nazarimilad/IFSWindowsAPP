using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Passenger
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public Seat Seat { get; private set; }
        public string ReservationNumber { get; private set; }
        public IEnumerable<Order> Orders { get; set; }

        public Passenger(string firstName, string lastName, string email, Seat seat, string reservationNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Seat = seat;
            ReservationNumber = reservationNumber;
        }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
