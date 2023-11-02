using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Offer : IEntity
    {
        [Key] public long Id { get; set; }
        public long RequestId { get; set; }
        public int SupplierId { get; set; }
        public DateTime OfferTime { get; set; }
        public int OfferQuantity { get; set; }
        public float OfferUnitQuantity { get; set; }
        public decimal OfferPrice { get; set; }
        public byte OfferStatus { get; set; }

        public List<ManagementReport> ManagementReport { get; set; }
        public List<Stock> Stocks { get; set; }
        public Request Request { get; set; }
        public Supplier Supplier { get; set; }
    }
}
