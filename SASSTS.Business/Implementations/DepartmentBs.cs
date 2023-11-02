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
    public class DepartmentBs : IDepartmentBs
    {
        private readonly IDepartmentRepository _repository;
        public DepartmentBs(IDepartmentRepository repository)
        {
            _repository = repository;
        }
        public async Task<ApiResponse<Department>> GetById(byte id)
        {
            var department = await _repository.GetAsync(x => x.Id == id);
            return ApiResponse<Department>.Success(StatusCodes.Status200OK, department);
        }
    }
}
