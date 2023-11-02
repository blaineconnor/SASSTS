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
    public class AuthorityBs : IAuthorityBs
    {
        private readonly IAuthoritiesRepository _authoritiesRepository;
        public AuthorityBs(IAuthoritiesRepository authoritiesRepository)
        {
            _authoritiesRepository = authoritiesRepository;
        }

        public async Task<ApiResponse<List<Authority>>> GetAllAsync()
        {
            var authorities = await _authoritiesRepository.GetAllAsync();
            return ApiResponse<List<Authority>>.Success(StatusCodes.Status200OK, authorities);
        }
    }
}
