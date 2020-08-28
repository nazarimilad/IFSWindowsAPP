using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class FlightAttendant
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; set; }
        public string Email { get; private set; }
        public string Token{ get; set; }

        public FlightAttendant(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
