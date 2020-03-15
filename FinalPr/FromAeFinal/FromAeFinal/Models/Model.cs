﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

     
        public Marka Marka { get; set; }
        public int MarkaId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
