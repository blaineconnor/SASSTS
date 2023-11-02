using Infrastructure.ApiResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SASSTS.Business.Interfaces;
using SASSTS.DataAccess.Interfaces;
using SASSTS.Model.Entities;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Security.JWT
{
    public class JwtGenerator
    {
        private readonly IAuthoritiesRepository _authoritiesRepository;
        private readonly IConfiguration _configuration;
        private TokenOptions _tokenOptions;
        private DateTime _tokenExpiration;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ICompanyBs _companyBs;
        private readonly IDepartmentBs _departmentBs;

        public JwtGenerator(IConfiguration configuration, IEmployeeRepository employeeRepository,
            IAuthoritiesRepository authoritiesRepository, ICompanyBs companyBs, IDepartmentBs departmentBs)
        {
            _configuration = configuration;
            _tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
            _employeeRepository = employeeRepository;
            _authoritiesRepository = authoritiesRepository;
            _companyBs = companyBs;
            _departmentBs = departmentBs;
        }

        public async Task<AccessToken> CreateAccessToken(long employeeId)
        {
            var employee = await _employeeRepository.GetById(employeeId);
            var authority = await _authoritiesRepository.GetAsync(x => x.Id == employee.AuthorityId);
            var department = await _departmentBs.GetById(employee.DepartmentId);
            var company = await _companyBs.GetByIdAsync(employee.CompanyId);

            _tokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.TokenExpiration);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("StokTakipveYönetimSistemiGirisAnahtari"));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, employee.EmployeeName),
                    new Claim(ClaimTypes.Role, authority.AuthorityName)
                }),
                Expires = _tokenExpiration,
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tok =  tokenHandler.WriteToken(token);

            var data = new AccessToken { Token = tok, Claims = new List<string> { $"{employee.EmployeeName}", $"{authority.AuthorityName}", 
                $"{employee.Id}", $"{employee.CompanyId}", $"{employee.DepartmentId}",$"{company.Data!.CompanyName}", $"{department.Data!.DepartmentName}"}, 
                Expiration = DateTime.Now };
            return data;
        }
    }
}