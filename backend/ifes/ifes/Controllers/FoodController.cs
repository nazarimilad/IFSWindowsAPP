using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.Models.Catalogs.FoodAndBeverage;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ifes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IRepository<Food> _foodrepo;

        public FoodController(IRepository<Food> foodRepo) {
            _foodrepo = foodRepo;

        }
        // GET: api/Food
        [HttpGet]
        public IActionResult Get()
        {
            var allFoods =  _foodrepo.GetList(x => x.Id != null);
            return Ok(allFoods);
        }

        // POST: api/Food
        [HttpPost]
        public  IActionResult Post([FromBody] AddFoodModel model)
        {
            Food food = new Food(model);
            _foodrepo.Add(food);
            if( _foodrepo.SaveChanges() == 0) throw new ApplicationException("failed to create food");
            return Ok(food);

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
