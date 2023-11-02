using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Accounting : IEntity
    {
        [Key]public long Id { get; set; }
        public long EmployeeId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public Employee Employee { get; set; }
    }
}
