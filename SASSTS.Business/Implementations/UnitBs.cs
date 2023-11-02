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
    public class UnitBs : IUnitBs
    {
        private readonly IUnitRepository _unitRepository;
        public UnitBs(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task<ApiResponse<List<Unit>>> GetAllUnits()
        {
            var units = await _unitRepository.GetAllAsync();
            return ApiResponse<List<Unit>>.Success(StatusCodes.Status200OK, units);
        }
    }
}
