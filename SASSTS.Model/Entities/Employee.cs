using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Employee : IEntity
    {
        [Key] public long Id { get; set; }
        public byte RoleId { get; set; }
        public byte AuthorityId { get; set; }
        public byte CompanyId { get; set; }
        public byte DepartmentId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }

        public List<Accounting> Accountings { get; set; }
        public Company Company { get; set; }
        public List<ProcessHistory> ProcessHistories { get; set; }
        public Authority Authority { get; set; }
        public Role Role { get; set; }
        public Department Department { get; set; }
        public List<Request> Requests { get; set; }
    }
}
