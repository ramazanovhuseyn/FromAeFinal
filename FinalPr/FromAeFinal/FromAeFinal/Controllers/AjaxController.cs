using FromAeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Controllers
{
    public class AjaxController : Controller
    {
        private readonly FromAeDbContext dbContext;
        public AjaxController(FromAeDbContext fromAe)
        {
            dbContext = fromAe;
        }
        public async Task<IActionResult> GetCategoriesById(int id)
        {
            var data = await dbContext.Categories.Where(w => w.SubMenuId == id).ToListAsync();
            return PartialView("_Category",data);
        }
    }
}