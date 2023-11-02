using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("requests")]
    [ApiController]
    public class RequestController : BaseController
    {
        private readonly IRequestBs _requestBs;
        public RequestController(IRequestBs requestBs)
        {
            _requestBs = requestBs;
        }

        [HttpGet("getRequests")]
        public async Task<IActionResult> GetRequests()
        {
            var response = await _requestBs.GetAllRequests();
            return SendResponse(response);  
        }

        [HttpPost("insertRequest")]
        public async Task<IActionResult> Create([FromBody]dynamic model)
        {
            var response = await _requestBs.InsertRequest(model);   
            return SendResponse(response);  
        }

        [HttpGet("getbyCompandDep")]
        public async Task<IActionResult> GetbyCompanyId([FromQuery] int companyId, int departmentId)  //buraya giriş yapan elamanın companyId ve departmentId değeri gelecek.
        {
            var response = await _requestBs.GetbyCompanyNo(companyId, departmentId);
            return SendResponse(response);
        }







        [HttpGet("getbyrequestId")]
        public async Task<IActionResult> GetbyId([FromQuery] long id)
        {
            var response = await _requestBs.GetbyIdAsync(id);
            return SendResponse(response);
        }




        //Request onaylama işlemi requestId geliyor bize.
        [HttpPut("updateRequest")]
        public async Task<IActionResult> Update([FromQuery]long id)
        {
            var response = await _requestBs.UpdateAsync(id);
            return SendResponse(response);
        }


        [HttpDelete("deleteRequest")]
        public async Task<IActionResult> DeleteRequest([FromQuery] long id)
        {
            var response = await _requestBs.DeleteAsync(id);
            return SendResponse(response);
        }

        [HttpGet("getallCount")]
        public IActionResult GetAllCount()
        {
            int value = _requestBs.Count();
            return Ok(value);
        }

       }
}
