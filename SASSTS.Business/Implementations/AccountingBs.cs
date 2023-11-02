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
    public class AccountingBs : IAccountingBs
    {
        private readonly IAccountingRepository _accountingRepository;
        public AccountingBs(IAccountingRepository accountingRepository)
        {
            _accountingRepository = accountingRepository;   
        }
        public async Task<ApiResponse<List<Accounting>>> GetAccounting()
        {
            var accounting = await _accountingRepository.GetAllAsync();
            return ApiResponse<List<Accounting>>.Success(StatusCodes.Status200OK, accounting);
        }
    }
}
