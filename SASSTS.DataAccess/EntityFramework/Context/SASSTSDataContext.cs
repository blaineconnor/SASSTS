using Microsoft.EntityFrameworkCore;
using SASSTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.DataAccess.EntityFramework.Context
{
    public class SASSTSDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=SASSTS;Integrated Security=true; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Accounting> Accountings  { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketDetail> BasketDetails { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ManagementReport> ManagementReports { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<ProcessHistory> ProcessHistories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}
