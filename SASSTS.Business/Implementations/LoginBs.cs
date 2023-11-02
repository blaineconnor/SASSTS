using Infrastructure.ApiResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SASSTS.Business.Interfaces;
using SASSTS.Business.Security.JWT;
using SASSTS.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Implementations
{
    public class LoginBs : ILoginBs
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IAuthoritiesRepository _authoritiesRepository;
        private readonly IConfiguration _configuration;
        private readonly ICompanyBs _companyBs;
        private readonly IDepartmentBs _departmentBs;
        public LoginBs(ILoginRepository loginRepository, IConfiguration configuration, IEmployeeRepository employeeRepository,
            IAuthoritiesRepository authoritiesRepository, ICompanyBs companyBs, IDepartmentBs departmentBs)
        {
            _loginRepository = loginRepository;
            _configuration = configuration;
            _employeeRepository = employeeRepository;
            _authoritiesRepository = authoritiesRepository;
            _companyBs = companyBs;
            _departmentBs = departmentBs;
        }

        public async Task<ApiResponse<AccessToken>> LoginAsync(string userName, string userPassword)
        {
            var result = _loginRepository.GetByEmployee(userName, userPassword);
            var accessToken = await new JwtGenerator(_configuration, _employeeRepository, _authoritiesRepository,
                _companyBs, _departmentBs).CreateAccessToken(result.EmployeeId);
            if (accessToken is not null)
                return ApiResponse<AccessToken>.Success(StatusCodes.Status200OK, accessToken);
            return ApiResponse<AccessToken>.Fail(StatusCodes.Status401Unauthorized, "token üretilemedi");
        }
    }
}
