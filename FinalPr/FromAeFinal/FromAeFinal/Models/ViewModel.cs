using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class ViewModel
    {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Comment> comments { get; set; }
        public IEnumerable<Image> images { get; set; }
        public IEnumerable<Marka> markas { get; set; }
        public IEnumerable<Menu> menus { get; set; }
        public IEnumerable<SubMenu> subMenus { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Model> models { get; set; }
        public IEnumerable<Property> properties {get;set;}
        public IEnumerable<ProductProperty> productProperties { get; set; }
        public IEnumerable<ProductCategory> productCategories  { get; set; }
        public IEnumerable<Rating> ratings { get; set; }
    }
}
