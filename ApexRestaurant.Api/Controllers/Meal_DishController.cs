using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMeal_Dish;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
    [Route("api/meal_Dish")]
    public class Meal_DishController : ControllerBase
    {
        private readonly IMeal_DishService _meal_DishService;
        public Meal_DishController(IMeal_DishService meal_DishService)
        {
            _meal_DishService = meal_DishService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var meal_Dish = _meal_DishService.GetById(id);
            if (meal_Dish == null)
                return NotFound();
            return Ok(meal_Dish);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var meal_Dishs = _meal_DishService.GetAll();
            return Ok(meal_Dishs);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Meal_Dish model)
        {
            _meal_DishService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Meal_Dish model)
        {
            _meal_DishService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Meal_Dish model)
        {
            _meal_DishService.Delete(model);
            return Ok();
        }
    }
}