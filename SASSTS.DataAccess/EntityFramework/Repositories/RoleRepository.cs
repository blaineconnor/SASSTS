using Infrastructure.DataAccess.Implementations;
using SASSTS.DataAccess.EntityFramework.Context;
using SASSTS.DataAccess.Interfaces;
using SASSTS.Model.Entities;

namespace SASSTS.DataAccess.EntityFramework.Repositories
{
    public class RoleRepository : BaseRepository<Role, SASSTSDataContext>, IRoleRepository
    {
    }
}
