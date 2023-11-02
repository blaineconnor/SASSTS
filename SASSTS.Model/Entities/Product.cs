using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Product : IEntity
    {
        [Key] public int Id { get; set; }
        public byte CategoryId { get; set; }
        public byte UnitId {get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }

        public Unit Unit { get; set; }
        public List<BasketDetail> BasketDetails { get; set; }
        public Category Category { get; set; }
    }
}
