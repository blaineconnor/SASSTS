using Infrastructure.DataAccess.Implementations;
using SASSTS.Business.Interfaces;
using SASSTS.DataAccess.EntityFramework.Context;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.DataAccess.EntityFramework.Repositories
{
    public class CompanyRepository : BaseRepository<Company, SASSTSDataContext>, ICompanyRepository
    {
        public async Task<Company> GetByCompanyNo(string companyNo)
        {
            return await GetAsync(x => x.CompanyNo == companyNo);
        }

        public async Task<Company> GetById(byte id)
        {
            return await GetAsync(x => x.Id == id);
        }
    }
}
