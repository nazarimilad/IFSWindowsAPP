using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.Controllers.Helpers;
using ifes.lib.domain.Users;
using ifes.lib.DTOs.UsersDtos;
using ifes.lib.Models.Users;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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

            var passenger = _passengerRepo.Get(x => x.ReservationCode == model.ReservationCode);
            if (null == passenger) throw new ArgumentException("incorrect reservationCode");

            var result = await _signInManager.PasswordSignInAsync(passenger.UserName, "Test123!", false, false);
            if (result.Succeeded) {
                var token = TokenHelper.GetToken(passenger);

                var crew = new PassengerDto {
                    UserName = passenger.UserName,
                    Id = passenger.Id,
                    Token = token
                };

                return Ok(crew);


            }
            throw new ArgumentException("incorrect reservationCode");

        }
    }
}
