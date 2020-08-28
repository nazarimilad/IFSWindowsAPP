using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.data;
using ifes.lib.domain.Planes;
using ifes.lib.DTOs.PlaneDtos;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ifes.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly IRepository<Plane> _planeRepo;
        private readonly ApplicationDbContext _context;
        public SeatController(IRepository<Plane> planeRepo, ApplicationDbContext context ) {
            _planeRepo = planeRepo;
            this._context = context;
        }
        // GET: api/Seat
        [HttpGet]
        public IActionResult GetPlaneSeatsWithPassenger([FromQuery] Guid planeId)
        {
            var plane = _planeRepo.Query(x => true).Include(x => x.Seats).ThenInclude(y => y.Passenger).FirstOrDefault();
            var seats = plane.Seats.Select(p => new SeatDto(p)).OrderBy(p => p.Row).ThenBy(p => p.Col);
            return Ok(seats);
        }

        [HttpPut]
        public IActionResult SwitchSeats([FromQuery] Guid planeId, string firstPassengerId, string secondPassengerId)
        {
            var plane = _planeRepo.Query(x => true).Include(x => x.Seats).ThenInclude(y => y.Passenger).FirstOrDefault();
            plane.SwitchUserSeats(firstPassengerId, secondPassengerId);
            _planeRepo.SaveChanges();
            return Ok();
        }



        // POST: api/Seat
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Seat/5
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
