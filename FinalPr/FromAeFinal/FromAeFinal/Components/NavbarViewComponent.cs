using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Components
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly FromAeDbContext _context;
        public NavbarViewComponent(FromAeDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var navbar = await _context.Menus.ToListAsync();
            return View(navbar);
        }
    }
}
