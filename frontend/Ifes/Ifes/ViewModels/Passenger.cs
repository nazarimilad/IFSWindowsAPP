using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Ifes.ViewModels
{
    public class Passenger
    {
        //public string FirstName { get; private set; }
        //public string LastName { get; private set; }
        public string UserName { get; set; }
        public string Email { get; private set; }
        public string ReservationNumber { get;set; }
        public string Id { get; set; }

        public string Token { get; set; }
        [JsonProperty("planeId")]
        public Guid PlaneId { get; set; }
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

        public bool MatchesSearch(string querry)
        {
            if(UserName.ToLower().Contains(querry.ToLower()) || ReservationNumber.Contains(querry.ToLower()))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{UserName}";
        }

        public static implicit operator Passenger(ItemClickEventArgs v)
        {
            throw new NotImplementedException();
        }
    }
}
