using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Controllers
{
    public class CategoriesPage : Controller
    {
        private readonly FromAeDbContext _context;
        public CategoriesPage(FromAeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            ViewBag.SubMenuName = _context.SubMenus.Where(x=>x.Id == id).Select(x=>x.Name).ToList();
            var category = _context.Categories.Where(x => x.SubMenuId == id).ToList();
            return View(category);
        }
    }
}
