using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Implementations;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductBs _productBs;
        public ProductController(IProductBs productBs)
        {
            _productBs = productBs;
        }

        [HttpGet("getProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var response = await _productBs.GetAllProducts();
            return SendResponse(response);
        }


        [HttpGet("getallbycategoryId")]
        public async Task<IActionResult> GetbyCategoryId([FromQuery] byte categoryId)
        {
            var response = await _productBs.GetbyCategoryIdAsync(categoryId);
            return SendResponse(response);
        }
    }
}
