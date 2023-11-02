using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Basket : IEntity
    {
        [Key]public int Id { get; set; }
        public DateTime CreatedTime { get; set; }

        public List<BasketDetail> BasketDetails { get; set; }
        public List<Request> Requests { get; set; }
    }
}
