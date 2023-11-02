using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Stock : IEntity
    {
        [Key] public long Id { get; set; }
        public long OfferId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public float ProductUnitQuantity { get; set; }

        public Offer Offer { get; set; }
    }
}
