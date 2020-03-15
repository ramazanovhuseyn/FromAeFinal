using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Url { get; set; }
        public SubMenu SubMenu { get; set; }
        public int SubMenuId { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
