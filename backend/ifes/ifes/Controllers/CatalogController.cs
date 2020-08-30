using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ifes.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]

    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IRepository<Catalog> _catalogRepo;

        public CatalogController(IRepository<Catalog> catalogRepo) {
            _catalogRepo = catalogRepo;

        }
        // GET: api/Catalog/id
        [HttpGet]
        public  IActionResult Get([FromQuery]Guid catalogId)
        {
            var catalog = _catalogRepo.Query(x => x.Id == catalogId).Include(y => y.Items).FirstOrDefault();
            return Ok(catalog.Items);
        }



        // POST: api/Catalog
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Catalog/5
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
