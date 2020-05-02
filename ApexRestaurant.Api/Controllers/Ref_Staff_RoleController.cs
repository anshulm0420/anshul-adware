using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SRef_Staff_Role;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
    [Route("api/ref_Staff_Role")]
    public class Ref_Staff_RoleController : ControllerBase
    {
        private readonly IRef_Staff_RoleService _ref_Staff_RoleService;
        public Ref_Staff_RoleController(IRef_Staff_RoleService ref_Staff_RoleService)
        {
            _ref_Staff_RoleService = ref_Staff_RoleService;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var ref_Staff_Role = _ref_Staff_RoleService.GetById(id);
            if (ref_Staff_Role == null)
                return NotFound();
            return Ok(ref_Staff_Role);
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var ref_Staff_Roles = _ref_Staff_RoleService.GetAll();
            return Ok(ref_Staff_Roles);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Ref_Staff_Role model)
        {
            _ref_Staff_RoleService.Insert(model);

            return Ok();
        }
        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Ref_Staff_Role model)
        {
            _ref_Staff_RoleService.Update(model);
            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Ref_Staff_Role model)
        {
            _ref_Staff_RoleService.Delete(model);
            return Ok();
        }
    }
}