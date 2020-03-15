using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Images { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
