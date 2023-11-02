using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Bill : IEntity
    {
        [Key] public long Id { get; set; }
        public long RequestId { get; set; }
        public int SupplierId { get; set; }
        public string BillType { get; set; }
        public DateTime BillDate { get; set; }
        public string BillNumber { get; set; }
        public float UnitPrice { get; set; }
        public int KDV { get; set; }
        public float Discount { get; set; }
        public float ProductAmount { get; set; }
        public float TotalPrice { get; set; }
        public float TotalDiscount { get; set; }
        public float TotalKDV { get; set; }
        public float BillTotalPrice { get; set; }
        public string Currency { get; set; }

        public Supplier Supplier { get; set; }
        public Request Request { get; set; }
    }
}
