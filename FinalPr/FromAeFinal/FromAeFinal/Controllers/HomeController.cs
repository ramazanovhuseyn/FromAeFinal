using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAeFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
        public async Task<IActionResult> AddBasket (int id)
        {
            Product product = await _dbcontext.Products.FindAsync(id);
            if(product== null)
            {
                return NotFound();
            }
            List<BasketProVM> list;
            string currentBasket = HttpContext.Session.GetString("basket");
            if(currentBasket == null)
            {
                list = new List<BasketProVM>();
            }
            else
            {
                list = JsonConvert.DeserializeObject<List<BasketProVM>>(currentBasket);
            }
            var checkPro = list.FirstOrDefault(x => x.Id == id);
            if (checkPro==null)
            {
                BasketProVM basketPro = new BasketProVM()
                {
                    Id = product.Id,
                    MainImage = product.MainImage,
                    Name = product.Name,
                    Price = product.Price,
                    Count = 1
                };
                list.Add(basketPro);
            }
            else
            {
               checkPro.Count += 1;
            }
          
            string basket = JsonConvert.SerializeObject(list);
            HttpContext.Session.SetString("basket",basket);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Basket()
        {
            string basket = HttpContext.Session.GetString("basket");
            return View(JsonConvert.DeserializeObject<List<BasketProVM>>(basket));
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