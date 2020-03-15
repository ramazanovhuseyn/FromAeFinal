using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly FromAeDbContext _context;
        public MenuViewComponent(FromAeDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
           var menu = await _context.Menus.Include("SubMenus").ToListAsync();
            return View(menu);
        }
    }
}
