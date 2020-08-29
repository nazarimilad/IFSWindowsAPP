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
    sealed class PlaneService
    {

        private static readonly Lazy<PlaneService> lazy = new Lazy<PlaneService>(() => new PlaneService());

        public static PlaneService Instance { get { return lazy.Value; } }

        public List<Seat> Seats { get; set; }


        public PlaneService()
        {
            Seats = new List<Seat>();
        }


        public async Task<List<Seat>> LoadPassengers()
        {
            var client = new HttpClient();
            var pasjson = await client.GetStringAsync(new Uri("https://localhost:44319/api/Seat/GetPlaneSeatsWithPassenger", UriKind.Absolute));
            this.Seats = JsonConvert.DeserializeObject<List<Seat>>(pasjson);
            return this.Seats;
        }


        public async Task Switchseat(Seat  firstSeat, Seat secondSeat)
        {
            var client = new HttpClient();
            await client.PutAsync(new Uri($"https://localhost:44319/api/Seat/SwitchSeats?firstPassengerId={firstSeat.Passenger.Id.ToString()}&secondPassengerId={secondSeat.Passenger.Id.ToString()}", UriKind.Absolute),null);
        }


    }
}
