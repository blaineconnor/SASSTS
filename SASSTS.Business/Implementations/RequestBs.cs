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
    public class RequestBs : IRequestBs
    {
        private readonly IRequestRepository _repository;
        private readonly ICompanyBs _companyBs;
        private readonly IDepartmentBs _departmentBs;
        public RequestBs(IRequestRepository repository, ICompanyBs companyBs, IDepartmentBs departmentBs)
        {
            _repository = repository;
            _companyBs = companyBs;
            _departmentBs = departmentBs;
        }
        public async Task<ApiResponse<List<Request>>> GetAllRequests()
        {
            var requests = await _repository.GetAllAsync();
            return ApiResponse<List<Request>>.Success(StatusCodes.Status200OK, requests);
        }

        public async Task<ApiResponse<NoData>> InsertRequest(Request model)
        {
            await _repository.InsertAsync(model);   
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public async Task<ApiResponse<List<Request>>> GetbyCompanyNo(int companyId, int departmentId)
        {
            var company = await _companyBs.GetByIdAsync((byte)companyId);
            var department = await _departmentBs.GetById((byte)departmentId);

            var requests = await _repository.GetAllAsync(x => x.RequestStatus == 0 && x.RequestNo.Contains(company.Data!.CompanyNo)
            && x.RequestNo.Contains(department.Data!.DepartmentNo));

            return ApiResponse<List<Request>>.Success(StatusCodes.Status200OK, requests);
        }

        public async Task<ApiResponse<Request>> GetbyIdAsync(long id)
        {
            var request = await _repository.GetbyId(id);
            return ApiResponse<Request>.Success(StatusCodes.Status200OK ,request);
        }

        public async Task<ApiResponse<NoData>> UpdateAsync(long id)
        {
            var request = await _repository.GetbyId(id);
            request.RequestStatus = 1;
            await _repository.UpdateAsync(request);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public async Task<ApiResponse<NoData>> DeleteAsync(long id)
        {
            var request = await _repository.GetbyId(id);
            request.RequestStatus = 2;
            await _repository.UpdateAsync(request);
            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
        }

        public int Count()
        {
            var count = _repository.GetAllCount();
            return count;
        }

    }
}
