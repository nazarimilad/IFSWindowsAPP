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
    public sealed class AuthenticationService
    {
        private static readonly Lazy<AuthenticationService> lazy = new Lazy<AuthenticationService>(() => new AuthenticationService());

        public static AuthenticationService Instance { get { return lazy.Value; } }


        public Passenger Passenger { get; set; }
        public string JwtToken { get; private set; } = "";

        private AuthenticationService()
        {

        }

        public async Task<bool> LogIn(string email, string password)
        {

            try {
                using (var client = new HttpClient()) {

                    var model = new LoginFlightAttendant { UserName = email, Password = password };
                    string json = JsonConvert.SerializeObject(model);
                    HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                    var httpResponse = await client.PostAsync(new Uri("https://localhost:44319/api/Auth/CrewLogin", UriKind.Absolute), httpContent);
                    if (httpResponse.IsSuccessStatusCode) {
                        var content = await httpResponse.Content.ReadAsStringAsync();

                        var flightAttendant = JsonConvert.DeserializeObject<FlightAttendant>(content);
                        if (flightAttendant != null) {

                            JwtToken = flightAttendant.Token;
                            return true;
                        }
                    }

                }

            } catch (Exception e) {

                throw new ArgumentException("Something went wrong");
            }

            throw new ArgumentException("Invalid reservation number.");
        }

        public async Task<bool> LogIn(string reservationNumber)
        {
            try {
                using (var client = new HttpClient()) {

                    var model = new PassengerLoginModel { ReservationCode = reservationNumber };
                    string json = JsonConvert.SerializeObject(model);
                    HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                    var httpResponse = await client.PostAsync(new Uri("https://localhost:44319/api/Auth/PassengerLogin", UriKind.Absolute), httpContent);
                    if (httpResponse.IsSuccessStatusCode) {
                        var content = await httpResponse.Content.ReadAsStringAsync();

                        var passenger = JsonConvert.DeserializeObject<Passenger>(content);
                        if (passenger != null) {
                            Passenger = passenger;
                            JwtToken = passenger.Token;
                            return true;
                        }
                    }

                }

            } catch (Exception e) {

                throw new ArgumentException("Something went wrong");
            }

            throw new ArgumentException("Invalid reservation number.");
        }

        public void LogOut()
        {
            Passenger = null;
            JwtToken = "";
        }
    }
}
