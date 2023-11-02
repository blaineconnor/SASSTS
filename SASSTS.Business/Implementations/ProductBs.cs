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
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository _repository;
        public ProductBs(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse<List<Product>>> GetAllProducts()
        {
            var products = await _repository.GetAllAsync();
            return ApiResponse<List<Product>>.Success(StatusCodes.Status200OK, products);
        }

        public async Task<ApiResponse<List<Product>>> GetbyCategoryIdAsync(byte categoryId)
        {
            var products = await _repository.GetbyCategoryId(categoryId);
            return ApiResponse<List<Product>>.Success(StatusCodes.Status200OK, products);
        }
    }
}
