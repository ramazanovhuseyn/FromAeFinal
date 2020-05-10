using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class BasketProVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string MainImage { get; set; }
        public int Count { get; set; }
    }
}
