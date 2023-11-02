using Infrastructure.ApiResponses;
using Microsoft.AspNetCore.Http;
using SASSTS.Business.Interfaces;
using SASSTS.DataAccess.Interfaces;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Implementations
{
    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryBs(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<ApiResponse<List<Category>>> GetAllCategories()
        {
            var response = await _categoryRepository.GetAllAsync();
            return ApiResponse<List<Category>>.Success(StatusCodes.Status200OK, response);
        }

        public async Task<ApiResponse<Category>> GetbyIdAsync(byte id)
        {
            var category = await _categoryRepository.GetbyId(id);
            return ApiResponse<Category>.Success(StatusCodes.Status200OK, category);
        }
    }
}
