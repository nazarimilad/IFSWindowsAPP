using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.Mappers;
using ifes.lib.Models.Catalogs.FoodAndBeverage;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]

    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BeverageController : ControllerBase
    {
        private readonly IRepository<Beverage> _beverageRepo;
        private readonly BeverageMapper _beverageMapper;

        public BeverageController(IRepository<Beverage> beveragerepo, BeverageMapper beverageMapper) {
            _beverageRepo = beveragerepo;
            _beverageMapper = beverageMapper;

        }
        // GET: api/Beverage
        [HttpGet]
        public IActionResult Get() {
            var allBeverages = _beverageRepo.GetList(x => x.Id != null);
            var allBeveragesDtos = _beverageMapper.MapBeveragesDto(allBeverages);
            return Ok(allBeveragesDtos);
        }

        [HttpGet]
        public IActionResult GetById([FromQuery] Guid id) {
            var Beverage = _beverageRepo.Get(x => x.Id == id);
            var BeverageDto = _beverageMapper.MapBeverageDto(Beverage);
            return Ok(BeverageDto);
        }

        // POST: api/Beverage
        [HttpPost]
        public IActionResult Post([FromBody] AddBeverageModel model) {
            Beverage Beverage = new Beverage(model);
            _beverageRepo.Add(Beverage);
            if (_beverageRepo.SaveChanges() == 0) throw new ApplicationException("failed to create Beverage");
            var BeverageDto = _beverageMapper.MapBeverageDto(Beverage);
            return Ok(BeverageDto);

        }

        // PUT: api/Beverage/5
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
