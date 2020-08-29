using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.data;
using ifes.lib.DTOs.UsersDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ifes.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {


        private readonly ApplicationDbContext _context;

        public PassengerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Passenger
        [HttpGet]
        public IEnumerable<PassengerDto> GetWithSeats()
        {
            Guid guid = _context.Plane.FirstOrDefault().Id;
            return _context.Passenger.Include(p => p.Seat).Select(p => new PassengerDto(p, guid));
        }

        [HttpGet]
        public IEnumerable<PassengerDto> GetPassengersOfGroup(string passengerId)
        {
            Guid guid = _context.Plane.FirstOrDefault().Id;

            var group = _context.Passenger.Include(p => p.ReservationGroup).FirstOrDefault(p => p.Id == passengerId).ReservationGroup;
            var passengers = _context.ReservationGroups.Include(p => p.Passengers)
                .FirstOrDefault(predicate => predicate.Id == group.Id)
                .Passengers.Select(p => new PassengerDto(p, guid))
               .Where(p => p.Id != passengerId);
            return passengers;
        }


        // POST: api/Passenger
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Passenger/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
