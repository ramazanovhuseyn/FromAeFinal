using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FromAeFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly FromAeDbContext _dbcontext;
        public HomeController(FromAeDbContext _context)
        {
            _dbcontext = _context;
        }
        public void Test(int id)
        {
            var products = _dbcontext.ProductCategories.Where(x => x.CategoryId == 1).ToListAsync();
        }
        public IActionResult Index()
        {
            
            ViewModel viewModel = new ViewModel();
            viewModel.categories = _dbcontext.Categories.ToList();
            viewModel.products = _dbcontext.Products.ToList();
            viewModel.comments = _dbcontext.Comments.ToList();
            viewModel.images = _dbcontext.Image.ToList();
            viewModel.markas = _dbcontext.Markas.ToList();
            viewModel.models = _dbcontext.Models.ToList();
            viewModel.menus = _dbcontext.Menus.ToList();
            viewModel.subMenus = _dbcontext.SubMenus.ToList();
            viewModel.ratings = _dbcontext.Ratings.ToList();
            viewModel.properties = _dbcontext.Properties.ToList();
            viewModel.productProperties = _dbcontext.ProductProperties.ToList();
            viewModel.productCategories = _dbcontext.ProductCategories.ToList();
            //viewModel.productCategories = await _dbcontext.ProductCategories.Include(x => x.Category).ToListAsync();

            return View(viewModel);
        }
    }
}