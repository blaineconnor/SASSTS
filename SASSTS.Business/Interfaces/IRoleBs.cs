﻿using Infrastructure.ApiResponses;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Interfaces
{
    public interface IRoleBs
    {
        Task<ApiResponse<List<Role>>> GetAllAsync(); 
    }
}
