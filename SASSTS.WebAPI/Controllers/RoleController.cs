using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("roles")]
    [ApiController]
    public class RoleController : BaseController
    {
        private readonly IRoleBs _roleBs;
        public RoleController(IRoleBs roleBs)
        {
            _roleBs = roleBs;   
        }

        [HttpGet("getAllRoles")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _roleBs.GetAllAsync();
            return SendResponse(response);
        }
    }
}
