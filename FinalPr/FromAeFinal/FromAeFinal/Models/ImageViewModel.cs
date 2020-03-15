using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public IFormFile[] Images { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
