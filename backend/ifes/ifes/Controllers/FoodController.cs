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
    public class FoodController : ControllerBase
    {
        private readonly IRepository<Food> _foodrepo;
        private readonly FoodMapper _foodMapper;

        public FoodController(IRepository<Food> foodRepo, FoodMapper foodMapper) {
            _foodrepo = foodRepo;
            _foodMapper = foodMapper;

        }
        // GET: api/Food
        [HttpGet]
        public IActionResult Get()
        {
            var allFoods =  _foodrepo.GetList(x => x.Id != null);
            var allFoodsDtos = _foodMapper.MapFoodsDto(allFoods);
            return Ok(allFoodsDtos);
        }

        [HttpGet]
        public IActionResult GetById([FromQuery]Guid id) {
            var food = _foodrepo.Get(x => x.Id == id);
            var foodDto = _foodMapper.MapFoodDto(food);
            return Ok(foodDto);
        }

        // POST: api/Food
        [HttpPost]
        public  IActionResult Post([FromBody] AddFoodModel model)
        {
            Food food = new Food(model);
            _foodrepo.Add(food);
            if( _foodrepo.SaveChanges() == 0) throw new ApplicationException("failed to create food");
            var foodDto = _foodMapper.MapFoodDto(food);
            return Ok(foodDto);

        }

        // PUT: api/Food/5
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
