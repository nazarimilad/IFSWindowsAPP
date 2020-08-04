using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.domain.Planes;
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

        public SeatController(IRepository<Plane> planeRepo) {
            _planeRepo = planeRepo;
        }
        // GET: api/Seat
        [HttpGet]
        public IActionResult GetPlaneSeatsWithPassenger([FromQuery] Guid planeId)
        {
            var plane = _planeRepo.Query(x => x.Id == planeId).Include(x => x.Seats).ThenInclude(y => y.Passenger).FirstOrDefault();
            var seats = plane.Seats;
            return Ok(seats);
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
