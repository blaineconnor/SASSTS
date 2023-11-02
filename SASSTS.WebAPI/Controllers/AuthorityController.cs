using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("authority")]
    [ApiController]
    public class AuthorityController : BaseController
    {
        private readonly IAuthorityBs _authorityBs;
        public AuthorityController(IAuthorityBs authorityBs)
        {
            _authorityBs = authorityBs; 
        }

        [HttpGet("getAllAuthorities")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _authorityBs.GetAllAsync();
            return SendResponse(response);
        }
    }
}
