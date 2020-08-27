using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ifes.Controllers.Helpers;
using ifes.lib.domain.Users;
using ifes.lib.DTOs.PlaneDtos;
using ifes.lib.DTOs.UsersDtos;
using ifes.lib.Models.Users;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ifes.Controllers {
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase {


        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IRepository<CabinCrew> _cabinCrewRepo;
        private readonly IRepository<Passenger> _passengerRepo;

        public AuthController(SignInManager<ApplicationUser> signInManager, IRepository<CabinCrew> cabinCrewRepo, IRepository<Passenger> passengerRepo) {

            _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            _cabinCrewRepo = cabinCrewRepo ?? throw new ArgumentException(nameof(cabinCrewRepo));
            _passengerRepo = passengerRepo ?? throw new ArgumentException(nameof(passengerRepo));
        }
        [HttpPost]
        public async Task<IActionResult> CrewLogin([FromBody] LoginModel model) {

            var crewmem = _cabinCrewRepo.Get(x => x.UserName == model.UserName);

            if (null == crewmem) throw new ApplicationException("Email or password is wrong");

            var result = await _signInManager.PasswordSignInAsync(crewmem.UserName, model.Password, false, false);
            if (result.Succeeded) {
                var token = TokenHelper.GetToken(crewmem);

                var crew = new CabinCrewDto {
                    UserName = crewmem.UserName,
                    Id = crewmem.Id,
                    Token = token
                };

                return Ok(crew);
            }
            throw new ApplicationException("Email or password is wrong");
        }


        [HttpPost]
        public async Task<IActionResult> PassengerLogin([FromBody] PassengerLoginModel model) {

            var passenger = _passengerRepo.Query(x => x.ReservationCode == model.ReservationCode).Include(x => x.Seat).FirstOrDefault();
            if (null == passenger) throw new ArgumentException("incorrect reservationCode");

            var result = await _signInManager.PasswordSignInAsync(passenger.UserName, "Test123!", false, false);
            if (result.Succeeded) {
                var token = TokenHelper.GetToken(passenger);

                var passengerDto = new PassengerDto {
                    UserName = passenger.UserName,
                    PlaneId = passenger.Seat.PlaneId,
                    Id = passenger.Id,
                    Token = token,
                    Seat  = new SeatDto(passenger.Seat),

                };

                return Ok(passengerDto);


            }
            throw new ArgumentException("incorrect reservationCode");

        }
    }
}
