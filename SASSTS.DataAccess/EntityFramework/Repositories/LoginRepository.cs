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
    public class LoginRepository : BaseRepository<Accounting, SASSTSDataContext>, ILoginRepository
    {
        public Accounting GetByEmployee(string userName, string userPassword)
        {
            using(var context = new SASSTSDataContext())
            {
                var account = context.Accountings.First(x => x.UserName == userName && x.UserPassword == userPassword);
                return account;
            }
        }
    }
}
