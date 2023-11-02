using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("companies")]
    [ApiController]
    public class CompanyController : BaseController
    {
        private readonly ICompanyBs _companyBs;
        public CompanyController(ICompanyBs companyBs)
        {
            _companyBs = companyBs;
        }

        [Authorize(Roles = "Talep, Birim Amiri")]
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllCompanies()
        {
            var response = await _companyBs.GetAllAsync();
            return SendResponse(response);
        }
        [Authorize(Roles = "Birim Amiri")]
        [HttpGet("getbyId")]
        public async Task<IActionResult> GetById([FromQuery]byte id)
        {
            var response = await _companyBs.GetByIdAsync(id);
            return SendResponse(response);
        }

        [HttpGet("getCompanyNo")]
        public async Task<IActionResult> GetByCompanyNo(string companyNo)
        {
            var response = await _companyBs.GetByCompNoAsync(companyNo);
            return SendResponse(response);  
        }
    }
}
