using Infrastructure.ApiResponses;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Interfaces
{
    public interface ICompanyBs
    {
        Task<ApiResponse<List<Company>>> GetAllAsync();
        Task<ApiResponse<Company>> GetByIdAsync(byte id);
        Task<ApiResponse<Company>> GetByCompNoAsync(string companyNo);
        string RandomUret(int companyId, int departmentId);
    }
}
