using AutoMapper;
using Infrastructure.ApiResponses;
using Microsoft.AspNetCore.Http;
using SASSTS.Business.Interfaces;
using SASSTS.DataAccess.Interfaces;
using SASSTS.Model.Dtos.BasketDetail;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Implementations
{
    public class BasketDetailBs : IBasketDetailBs
    {
        private readonly IBasketDetailRepository _basketDetailRepository;
        private readonly IMapper _mapper;
        public BasketDetailBs(IBasketDetailRepository basketDetailRepository, IMapper mapper)
        {
            _basketDetailRepository = basketDetailRepository;
            _mapper = mapper;
        }
        public async Task<ApiResponse<List<BasketDetailGetDto>>> GetAllBasketDetail(params string[] includeList)
        {
            var details = await _basketDetailRepository.GetAllAsync(predicate: null!, includeList);

            var returnList = _mapper.Map<List<BasketDetailGetDto>>(details);
            return ApiResponse<List<BasketDetailGetDto>>.Success(StatusCodes.Status200OK, returnList);
        }

        public async Task<ApiResponse<NoData>> Insert(BasketDetail model)
        {
            if(model != null)
            {
                await _basketDetailRepository.InsertAsync(model);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new BadImageFormatException("veri null");
        }

        public async Task<ApiResponse<List<BasketDetailGetDto>>> GetAllRequestId(int id, params string[] includeList)
        {
            var basketDetails = await _basketDetailRepository.GetAllAsync(x => x.BasketId == id, includeList: includeList);
            var returnList = _mapper.Map<List<BasketDetailGetDto>>(basketDetails);
            return ApiResponse<List<BasketDetailGetDto>>.Success(StatusCodes.Status200OK, returnList);
        }

    }
}
