using Infrastructure.ApiResponses;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Interfaces
{
    public interface IRequestBs
    {
        Task<ApiResponse<List<Request>>> GetAllRequests();
        Task<ApiResponse<NoData>> InsertRequest(Request model);
        Task<ApiResponse<List<Request>>> GetbyCompanyNo(int companyId, int departmentId);
        Task<ApiResponse<Request>> GetbyIdAsync(long id);
        Task<ApiResponse<NoData>> UpdateAsync(long id);
        Task<ApiResponse<NoData>> DeleteAsync(long id);
        int Count();
    }
}
