using Infrastructure.ApiResponses;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Interfaces
{
    public interface ICategoryBs
    {
        Task<ApiResponse<List<Category>>> GetAllCategories();
        Task<ApiResponse<Category>> GetbyIdAsync(byte id);
    }
}
