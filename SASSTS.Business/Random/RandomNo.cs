using SASSTS.DataAccess.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SASSTS.DataAccess.EntityFramework
{
    //Bu sınıf RequestNo oluşturmaya hizmet edecek.
    public class RandomNo 
    {
        private readonly SASSTSDataContext _context;
        public RandomNo(SASSTSDataContext context)
        {
            _context = context;   
        }

        public string RandomUret(int companyId, int departmentId)
        {
            var companyNo = _context.Companies.First(c => c.Id == companyId).CompanyNo;
            var departmentNo = _context.Departments.First(d => d.Id == departmentId).DepartmentNo;

            var s = "";

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 1)
                {
                    char d = 'A';
                    char f = 'Z';
                    var c = Convert.ToChar(random.Next(d, f));
                    s += c;
                }
                else
                    s += random.Next(0, 10);
            }
            return (companyNo + departmentNo + s);
        }
    }
}
