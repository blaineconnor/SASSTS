using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class ProcessHistory : IEntity
    {
        [Key] public long Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime ProcessTime { get; set; }
        public string ProcessType { get; set; }
        public string ProcessDetail { get; set; }

        public Employee Employee { get; set; }
    }
}
