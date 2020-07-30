using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using ifes.lib.Enum;
using Microsoft.AspNetCore.Identity;

namespace ifes.lib.data {
    public class Init {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public Init(ApplicationDbContext context, UserManager<ApplicationUser> userManager) {
            _context = context;
            _userManager = userManager;
        }

        public void Run() {
            Task.WaitAll(InitPlane());
        }
        
        private async Task InitPlane() {
            var airPortFrom = new Airport {
                Name = "Brussels Airport", Code = "BRS",
                Country = "BElGIUM"
            };
            var airPortTo = new Airport {
                Name = "John F Kennedy (JFK). ", Code = "JFK",
                Country = "AMERICA"
            };
            var plane = new Plane(new FlightInfo(airPortFrom, airPortTo, DateTime.Now, DateTime.Now.AddHours(8)),
                new Catalog()) {
                TailNumber = "LMAO42069",
                Type = "AIRBUS A380"
            };

            for (var i = 1; i <= 3; i++) {
                plane.AddSeat('A', i, FlightClass.Business);

                plane.AddSeat('B', i, FlightClass.Business);
                plane.AddSeat('C', i, FlightClass.Business);
                plane.AddSeat('D', i, FlightClass.Business);
                plane.AddSeat('E', i, FlightClass.Business);
                plane.AddSeat('F', i, FlightClass.Business);
            }

            for (var i = 4; i <= 37; i++) {
                plane.AddSeat('A', i, FlightClass.Economy);
                plane.AddSeat('B', i, FlightClass.Economy);
                plane.AddSeat('C', i, FlightClass.Economy);
                plane.AddSeat('D', i, FlightClass.Economy);
                plane.AddSeat('E', i, FlightClass.Economy);
                plane.AddSeat('F', i, FlightClass.Economy);
            }

            for (var i = 1; i < 40; i++) {
                var list = new List<char>() {
                    'A',
                    'B',
                    'C',
                    'D',
                    'E',
                    'F',
                };

                foreach (var c in list) {
                    var passenger = new Passenger() {
                        ReservationCode = "LKFJDKJDF" + i,
                        UserName = "Passenger" + i
                    };
                    var a = await _userManager.CreateAsync(passenger, "Test123!");
                    if (a != IdentityResult.Success) continue;
                    var passengerInit = await _userManager.FindByNameAsync("Passenger" + i);
                    plane.AssingPassengerToSeat(passengerInit as Passenger, c, i);
                }
            }

            for (var i = 0; i < 4; i++) {
                var crewMem = new CabinCrew() {
                    UserName = "CrewMem" + i,
                };
                var a = await _userManager.CreateAsync(crewMem, "Test123!");
                if (a != IdentityResult.Success) continue;
                var crewManInit = await _userManager.FindByNameAsync("CrewMem" + i);
                plane.PutCrewManToWork(crewManInit as CabinCrew);
            }

            plane.Catalog.Items.AddRange((InitMovies.GetVideos()));
            plane.Catalog.Items.Add(new);
        }
    }
}