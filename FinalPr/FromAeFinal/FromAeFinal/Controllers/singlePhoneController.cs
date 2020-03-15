using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FromAeFinal.Controllers
{
    public class singlePhoneController : Controller
    {
        private readonly FromAeDbContext _dbContext;
        public singlePhoneController(FromAeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(int id)
        {
            ViewBag.Property = _dbContext.ProductProperties.Where(x => x.ProductId == id).Select(x => x.Property.Name).ToList();
            ViewBag.PropertyValue = _dbContext.ProductProperties.Where(x => x.ProductId == id).Select(x => x.Value).ToList();
            return View(_dbContext.Products.Find(id));
            
        }
    }
}