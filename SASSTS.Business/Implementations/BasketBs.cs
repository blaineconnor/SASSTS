
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
    public class BasketBs : IBasketBs
    {
        private readonly IBasketRepository _repository;
        public BasketBs(IBasketRepository repository)
        {
            _repository = repository;
        }
        public async Task<ApiResponse<List<Basket>>> GetAllBaskets()
        {
            var baskets = await _repository.GetAllAsync();
            return ApiResponse<List<Basket>>.Success(StatusCodes.Status200OK, baskets);
        }

        public async Task<ApiResponse<Basket>> InsertBasket(Basket model)
        {
            var basket = await _repository.InsertAsync(model);
            return ApiResponse<Basket>.Success(StatusCodes.Status200OK, basket);    
        }
    }
}
