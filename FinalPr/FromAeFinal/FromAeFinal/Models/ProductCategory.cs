using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class ProductCategory
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
