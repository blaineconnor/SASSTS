using Azure.Core;
using Infrastructure.DataAccess.Interfaces;
using SASSTS.DataAccess.EntityFramework.Context;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.DataAccess.Interfaces
{
    public interface IRequestRepository : IBaseRepository<Model.Entities.Request>
    {
        Task<Model.Entities.Request> GetbyId(long id);
        int GetAllCount();
    }
}
