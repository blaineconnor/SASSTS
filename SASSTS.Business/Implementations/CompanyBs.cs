using Infrastructure.ApiResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
    //Loglama ve Fluent validationlar sonrasında detaylıca yapılacak ProcessHistories tablosu da sonrasında detaylı
    //bir şekilde doldurulucak en son da olabilir.
    public class CompanyBs : ICompanyBs
    {
        private readonly IDepartmentRepository _DepartmentRepository;
        private readonly ICompanyRepository _companyRepository;
        public CompanyBs(ICompanyRepository companyRepository, IDepartmentRepository departmentRepository)
        {
            _companyRepository = companyRepository;   
            _DepartmentRepository = departmentRepository;
        }
        public async Task<ApiResponse<List<Company>>> GetAllAsync()
        {
            var companies = await _companyRepository.GetAllAsync();
            return ApiResponse<List<Company>>.Success(StatusCodes.Status200OK, companies);
        }

        public async Task<ApiResponse<Company>> GetByCompNoAsync(string companyNo)
        {
            var company = await _companyRepository.GetByCompanyNo(companyNo);
            return ApiResponse<Company>.Success(StatusCodes.Status200OK, company);
        }

        public async Task<ApiResponse<Company>> GetByIdAsync(byte id)
        {
            var company = await _companyRepository.GetById(id);
            return ApiResponse<Company>.Success(StatusCodes.Status200OK, company);
        }

        public string RandomUret(int companyId, int departmentId)
        {
            var companyNo = _companyRepository.GetAsync(x => x.Id == companyId).Result.CompanyNo;
            var departmentNo = _DepartmentRepository.GetAsync(a => a.Id == departmentId).Result.DepartmentNo;   

            var s = "";

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 1)
                {
                    char d = 'A';
                    char f = 'Z';
                    var c = Convert.ToChar(random.Next(d, f));
                    s += c;
                }
                else
                    s += random.Next(0, 10);
            }
            return (companyNo + departmentNo + s);
        }

    }
}
