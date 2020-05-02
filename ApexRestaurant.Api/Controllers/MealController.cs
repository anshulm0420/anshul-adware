using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMeal;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
    [Route("api/meal")]
    public class MealController : ControllerBase
    {
        private readonly IMealService _mealService;
        public MealController(IMealService mealService)
        {
            _mealService = mealService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var meal = _mealService.GetById(id);
            if (meal == null)
                return NotFound();
            return Ok(meal);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var meals = _mealService.GetAll();
            return Ok(meals);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Meal model)
        {
            _mealService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Meal model)
        {
            _mealService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Meal model)
        {
            _mealService.Delete(model);
            return Ok();
        }
    }
}