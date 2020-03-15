using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public byte? Discount { get; set; }
        public IFormFile MainImage { get; set; }
        public ICollection<ProductProperty> ProductProperties { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

        public ICollection<Image> Images { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
