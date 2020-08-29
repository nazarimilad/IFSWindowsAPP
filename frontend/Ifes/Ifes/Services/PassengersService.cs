using Ifes.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class PassengersService
    {
        private static readonly Lazy<PassengersService> lazy = new Lazy<PassengersService>(() => new PassengersService());

        public static PassengersService Instance { get { return lazy.Value; } }

        public List<Passenger> Passengers { get; set; }
        public List<Passenger> PassengersInReservationGroup { get; set; }
        private PassengersService()
        {
            Passengers = new List<Passenger>();
            PassengersInReservationGroup = new List<Passenger>();
        }


        public async Task<List<Passenger>> LoadPassengers()
        {
            var client = new HttpClient();
            var pasjson = await client.GetStringAsync(new Uri("https://localhost:44319/api/Passenger/GetWithSeats", UriKind.Absolute));
            this.Passengers = JsonConvert.DeserializeObject<List<Passenger>>(pasjson);
            return this.Passengers;
        }

        public async Task LoadReservationGroup()
        {
            var currentPassenger = AuthenticationService.Instance.Passenger;
            if (currentPassenger != null)
            {
                var client = new HttpClient();
                var pasjson = await client.GetStringAsync(new Uri($"https://localhost:44319/api/Passenger/GetPassengersOfGroup?passengerId={currentPassenger.Id}", UriKind.Absolute));
                this.PassengersInReservationGroup = JsonConvert.DeserializeObject<List<Passenger>>(pasjson);
            }
        }


    }
}
