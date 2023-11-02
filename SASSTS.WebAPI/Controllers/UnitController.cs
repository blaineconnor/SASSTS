using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("api/units")]
    [ApiController]
    public class UnitController : BaseController
    {
        private readonly IUnitBs _unitBs;
        public UnitController(IUnitBs unitBs)
        {
            _unitBs = unitBs;
        }
        [HttpGet("getUnits")]
        public async Task<IActionResult> GetUnits()
        {
            var response = await _unitBs.GetAllUnits(); 
            return SendResponse(response);  
        }
    }
}
