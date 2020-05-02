using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenu_Item;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
    [Route("api/menu_Item")]
    public class Menu_ItemController : ControllerBase
    {
        private readonly IMenu_ItemService _menu_ItemService;
        public Menu_ItemController(IMenu_ItemService menu_ItemService)
        {
            _menu_ItemService = menu_ItemService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var menu_Item = _menu_ItemService.GetById(id);
            if (menu_Item == null)
                return NotFound();
            return Ok(menu_Item);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var menu_Items = _menu_ItemService.GetAll();
            return Ok(menu_Items);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Menu_Item model)
        {
            _menu_ItemService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Menu_Item model)
        {
            _menu_ItemService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Menu_Item model)
        {
            _menu_ItemService.Delete(model);
            return Ok();
        }
    }
}