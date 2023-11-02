
using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController : BaseController
    {
        private readonly ILoginBs _loginBs;
        public LoginController(ILoginBs loginBs)
        {
            _loginBs = loginBs;
        }


        [HttpPost("getLogin")]
        public async Task<IActionResult> Login([FromQuery]string userName, [FromQuery]string userPassword)
        {
            var response = await _loginBs.LoginAsync(userName, userPassword);
            return SendResponse(response);
        }
    }
}
