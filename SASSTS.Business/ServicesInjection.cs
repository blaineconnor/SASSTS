using SASSTS.Business.Implementations;
using SASSTS.Business.Interfaces;
using SASSTS.Business.Profiles;
using SASSTS.DataAccess.EntityFramework.Repositories;
using SASSTS.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSTS.Business.Profiles.BasketDetail;

namespace SASSTS.Business
{
    public static class ServicesInjection
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BasketDetailProfile));

            services.AddScoped<IAccountingRepository, AccountingRepository>();
            services.AddScoped<IBasketDetailRepository, BasketDetailRepository>();
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IUnitRepository, UnitRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IAuthoritiesRepository, AuthorityRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            
            services.AddScoped<IDepartmentBs, DepartmentBs>();
            services.AddScoped<ILoginBs, LoginBs>();
            services.AddScoped<IAuthorityBs, AuthorityBs>();
            services.AddScoped<IRoleBs, RoleBs>();
            services.AddScoped<IAccountingBs, AccountingBs>();
            services.AddScoped<IBasketDetailBs, BasketDetailBs>();
            services.AddScoped<IUnitBs, UnitBs>();
            services.AddScoped<IProductBs, ProductBs>();
            services.AddScoped<IRequestBs, RequestBs>();
            services.AddScoped<IBasketBs, BasketBs>();
            services.AddScoped<ICategoryBs, CategoryBs>();
            services.AddScoped<ICompanyBs, CompanyBs>();
            services.AddScoped<IEmployeeBs, EmployeeBs>();
        }
    }
}
