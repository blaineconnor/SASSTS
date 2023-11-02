using Infrastructure.DataAccess.Implementations;
using SASSTS.DataAccess.EntityFramework.Context;
using SASSTS.DataAccess.Interfaces;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.DataAccess.EntityFramework.Repositories
{
    public class RequestRepository : BaseRepository<Request, SASSTSDataContext>, IRequestRepository
    {
        public async Task<Request> GetbyId(long id)
        {
            return await GetAsync(x => x.Id == id);
        }

        public int GetAllCount()
        {
            using (SASSTSDataContext context = new SASSTSDataContext())
            {
                int value = context.Requests.Where(x => x.RequestStatus == 0).Count();
                if(value > 0)
                    return value;
                return 0;
            }

        }
    }
}
