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
    public class RoleBs : IRoleBs
    {
        private readonly IRoleRepository _roleRepository;
        public RoleBs(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<ApiResponse<List<Role>>> GetAllAsync()
        {
            var roles = await _roleRepository.GetAllAsync();
            return ApiResponse<List<Role>>.Success(StatusCodes.Status200OK, roles);
        }
    }
}
