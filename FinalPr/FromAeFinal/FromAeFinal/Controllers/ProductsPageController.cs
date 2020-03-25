using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FromAeFinal.Controllers
{
    public class ProductsPageController : Controller
    {
        private readonly FromAeDbContext _dbcontext;
        public ProductsPageController(FromAeDbContext context)
        {
            _dbcontext = context;
        }
        public void Test(int id)
        {
            var products = _dbcontext.ProductCategories.Where(x => x.CategoryId == 1).ToListAsync();
        }
        public IActionResult Index(int id)
        {
            ViewBag.Istehsalci = (from m in _dbcontext.Markas
                                  join mo in _dbcontext.Models
                                  on m.Id equals mo.MarkaId
                                  join p in _dbcontext.Products on mo.Id equals p.ModelId
                                  join pc in _dbcontext.ProductCategories on p.Id equals pc.ProductId
                                  join c in _dbcontext.Categories on pc.CategoryId equals c.Id
                                  where c.Id == id
                                  select m.Name).Distinct();

            ViewBag.Count = (from m in _dbcontext.Markas
                             join mo in _dbcontext.Models
                             on m.Id equals mo.MarkaId
                             join p in _dbcontext.Products on mo.Id equals p.ModelId
                             join pc in _dbcontext.ProductCategories on p.Id equals pc.ProductId
                             join c in _dbcontext.Categories on pc.CategoryId equals c.Id
                             where c.Id == id
                             select p.Name).Count();

            ViewBag.Prop = (from c in _dbcontext.Categories
                            join pc in _dbcontext.ProductCategories
                            on c.Id equals pc.CategoryId
                            join p in _dbcontext.Products
                            on pc.ProductId equals p.Id
                            join pp in _dbcontext.ProductProperties
                            on p.Id equals pp.ProductId
                            join pr in _dbcontext.Properties
                            on pp.PropertyId equals pr.Id
                            where c.Id == id
                            select pr.Name).ToList();

            ViewBag.Value = (from c in _dbcontext.Categories
                             join pc in _dbcontext.ProductCategories
                             on c.Id equals pc.CategoryId
                             join p in _dbcontext.Products
                             on pc.ProductId equals p.Id
                             join pp in _dbcontext.ProductProperties
                             on p.Id equals pp.ProductId
                             join pr in _dbcontext.Properties
                             on pp.PropertyId equals pr.Id
                             where c.Id == id &  pr.Id==pp.PropertyId
                             select pp.Value).Distinct();

            ViewBag.Name = _dbcontext.ProductCategories.Where(x => x.CategoryId == id).Select(y => y.Category.Name).ToList();
            ViewModel viewModel = new ViewModel();
            //viewModel.categories = _dbcontext.Categories.ToList();
            //viewModel.products = _dbcontext.Products.ToList();
            //viewModel.productCategories = _dbcontext.ProductCategories.ToList();
            var prooduct = _dbcontext.Products.Where(x => x.ProductCategories.Any(y => y.CategoryId == id));
            return View(prooduct);
        }
    }
}