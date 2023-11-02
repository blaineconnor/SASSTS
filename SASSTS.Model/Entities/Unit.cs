﻿using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Model.Entities
{
    public class Unit : IEntity
    {
        [Key] public byte Id { get; set; }
        public string UnitName { get; set; }

        public List<Product> Products { get; set; }
    }
}
