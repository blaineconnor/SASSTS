using Microsoft.AspNetCore.Mvc;
using SASSTS.Business.Interfaces;

namespace SASSTS.WebAPI.Controllers
{
    [Route("api/accountings")]
    [ApiController]
    public class AccountingController : BaseController
    {
        private readonly IAccountingBs _accountingBs;
        public AccountingController(IAccountingBs accountingBs)
        {
            _accountingBs = accountingBs;
        }
        [HttpGet("getAccountings")]
        public async Task<IActionResult> GetAccounting()
        {
            var response = await _accountingBs.GetAccounting();
            return SendResponse(response);
        }
    }
}
