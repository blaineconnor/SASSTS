using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("basketDetails")]
    [ApiController]
    public class BasketDetailController : BaseController
    {
        private readonly IBasketDetailBs _detailBs;
        public BasketDetailController(IBasketDetailBs detailBs)
        {
            _detailBs = detailBs;
        }

        [HttpGet("getBaskets")]
        public async Task<IActionResult> GetBaskets()
        {
            var response = await _detailBs.GetAllBasketDetail("Product", "Basket");
            return SendResponse(response);
        }
        
        [HttpPost("insertBasketDetail")]
        public async Task<IActionResult> Create([FromBody] dynamic model)
        {
            var response = await _detailBs.Insert(model);
            return SendResponse(response);  
        }

        [HttpGet("getbyrequestId")]
        public async Task<IActionResult> GetbyRequestId([FromQuery] int id)  //buraya requestten basketId gelecek.
        {
            var response = await _detailBs.GetAllRequestId(id, "Product", "Basket");   //Model
            return SendResponse(response);
        }
    }
}
