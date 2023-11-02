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
    public class AccountingRepository : BaseRepository<Accounting, SASSTSDataContext>, IAccountingRepository
    {
    }
}
