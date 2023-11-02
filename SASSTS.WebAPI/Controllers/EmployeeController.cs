using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("employees")]
    [ApiController]
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeBs _employeeBs;
        public EmployeeController(IEmployeeBs employeeBs)
        {
            _employeeBs = employeeBs;
        }

        [HttpGet("getAllEmployees")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _employeeBs.GetAllAsync();
            return SendResponse(response);
        }
    }
}
