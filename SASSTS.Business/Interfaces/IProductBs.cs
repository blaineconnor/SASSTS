using Infrastructure.ApiResponses;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Interfaces
{
    public interface IProductBs
    {
        Task<ApiResponse<List<Product>>> GetAllProducts();
        Task<ApiResponse<List<Product>>> GetbyCategoryIdAsync(byte categoryId);
    }
}
