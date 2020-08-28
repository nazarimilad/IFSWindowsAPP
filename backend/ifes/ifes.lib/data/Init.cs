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
using Microsoft.EntityFrameworkCore;

namespace ifes.lib.data
{
    public class Init
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public Init(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public void Run()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            Task.WaitAll(InitPlane());
        }

        private async Task InitPlane()
        {
            var airPortFrom = new Airport
            {
                Name = "Brussels Airport",
                Code = "BRS",
                Country = "BElGIUM"
            };
            var airPortTo = new Airport
            {
                Name = "John F Kennedy (JFK). ",
                Code = "JFK",
                Country = "AMERICA"
            };
            var plane = new Plane(new FlightInfo(airPortFrom, airPortTo, DateTime.Now, DateTime.Now.AddHours(8)),
                new Catalog())
            {
                TailNumber = "LMAO42069",
                Type = "AIRBUS A380"
            };

            for (var i = 1; i < 20; i++)
            {

                if (i < 4)
                {

                    plane.AddSeat("A", i, FlightClass.Business);
                    plane.AddSeat("B", i, FlightClass.Business);
                    plane.AddSeat("C", i, FlightClass.Business);
                    plane.AddSeat("D", i, FlightClass.Business);
                    plane.AddSeat("E", i, FlightClass.Business);
                    plane.AddSeat("F", i, FlightClass.Business);

                }
                else
                {
                    plane.AddSeat("A", i, FlightClass.Economy);
                    plane.AddSeat("B", i, FlightClass.Economy);
                    plane.AddSeat("C", i, FlightClass.Economy);
                    plane.AddSeat("D", i, FlightClass.Economy);
                    plane.AddSeat("E", i, FlightClass.Economy);
                    plane.AddSeat("F", i, FlightClass.Economy);
                }

            }
            _context.Plane.Add(plane);
            _context.SaveChanges();

            plane = _context.Plane.Include(p => p.Seats).FirstOrDefault();


            for (var i = 1; i < 20; i++)
            {
                var list = new List<string>() {
                    "A",
                    "B",
                    "C",
                    "D",
                    "E",
                    "F",
                };

                foreach (var c in list)
                {
                    var passenger = new Passenger()
                    {
                        ReservationCode = "LKFJDKJDF" + i,
                        UserName = "Passenger" + i + c
                    };
                    plane.AssingPassengerToSeat(passenger, c, i);
                    var a = await _userManager.CreateAsync(passenger, "Test123!");
                    if (a != IdentityResult.Success) continue;


                }
            }

            for (var i = 0; i < 4; i++)
            {
                var crewMem = new CabinCrew()
                {
                    UserName = "CrewMem" + i,
                };
                var a = await _userManager.CreateAsync(crewMem, "Test123!");
                if (a != IdentityResult.Success) continue;
                var crewManInit = await _userManager.FindByNameAsync("CrewMem" + i);
                plane.PutCrewManToWork(crewManInit as CabinCrew);
            }


            plane.Catalog = new Catalog();
            plane.Catalog.Items = new List<CatalogItem>();
            plane.Catalog.Items.AddRange((InitMovies.GetVideos()));

            plane.Catalog.Items.AddRange((AudioInit.GetAudio()));
            plane.Catalog.Items.AddRange((FoodInit.getFoods()));
            plane.Catalog.Items.AddRange((InitBeverage.GetBeverages()));
            //    plane.Catalog.Items.Add(new);


            _context.SaveChanges();
        }
    }
}