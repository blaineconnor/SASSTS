using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryBs _categoryBs;
        public CategoryController(ICategoryBs categoryBs)
        {
            _categoryBs = categoryBs;
        }

        [HttpGet("getCategories")]
        public async Task<IActionResult> GetCategories()
        {
            var response = await _categoryBs.GetAllCategories();
            return SendResponse(response);
        }

        [HttpGet("getbyId")]
        public async Task<IActionResult> GetbyId([FromQuery] byte id)
        {
            var response = await _categoryBs.GetbyIdAsync(id);
            return SendResponse(response);
        }
    }
}
