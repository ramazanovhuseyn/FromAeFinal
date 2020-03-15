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

            ViewBag.Name = _dbcontext.ProductCategories.Where(x => x.CategoryId == id).Select(y => y.Category.Name).ToList();
            ViewModel viewModel = new ViewModel();
            viewModel.categories = _dbcontext.Categories.ToList();
            viewModel.products = _dbcontext.Products.ToList();
            viewModel.productCategories = _dbcontext.ProductCategories.ToList();
            var prooduct = _dbcontext.Products.Where(x => x.ProductCategories.Any(y => y.CategoryId == id));
            return View(prooduct);
        }
    }
}