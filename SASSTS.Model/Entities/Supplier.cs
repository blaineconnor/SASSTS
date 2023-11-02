using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Supplier : IEntity
    {
        [Key] public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplirSurname { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }

        public Bill Bill { get; set; }
        public List<Offer> Offers { get; set; }
    }
}
