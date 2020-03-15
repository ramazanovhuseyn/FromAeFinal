using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAeFinal.Models;

namespace FromAeFinal.Models
{
    public class FromAeDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public FromAeDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId });
            builder.Entity<ProductProperty>().HasKey(x => new { x.PropertyId, x.ProductId });
            builder.Entity<ProductCategory>().HasOne(x => x.Product).WithMany(x => x.ProductCategories);
            builder.Entity<ProductCategory>().HasOne(x => x.Category).WithMany(x => x.ProductCategories);
            builder.Entity<ProductProperty>().HasOne(x => x.Property).WithMany(x => x.ProductProperties);
            builder.Entity<ProductProperty>().HasOne(x => x.Product).WithMany(x => x.ProductProperties);
        }
        public DbSet<FromAeFinal.Models.Image> Image { get; set; }
    }
}

