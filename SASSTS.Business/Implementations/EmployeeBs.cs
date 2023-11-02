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
    public class EmployeeBs : IEmployeeBs
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeBs(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<ApiResponse<List<Employee>>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return ApiResponse<List<Employee>>.Success(StatusCodes.Status200OK, employees);
        }
    }
}
