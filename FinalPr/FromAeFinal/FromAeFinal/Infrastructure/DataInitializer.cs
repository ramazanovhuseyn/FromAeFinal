using FromAeFinal.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FromAeFinal.Infrastructure
{
    public class DataInitializer
    {
        public static void Seed(IServiceScope scopedService)
        {
            using (var context = scopedService.ServiceProvider.GetRequiredService<FromAeDbContext>())
            {
                if (!context.Menus.Any())
                {
                    context.Menus.AddRange(
                         new Menu { Name = "Elektronika", Url = "#" }
                       , new Menu { Name = "Komputerlər", Url = "#" }
                       , new Menu { Name = "Oyunlar", Url = "#" }
                       , new Menu { Name = "Foto və Video", Url = "#" }
                       , new Menu { Name = "Məişət Avadanlıqları", Url = "#" }
                       , new Menu { Name = "Parfüm və Kosmetika", Url = "#" }
                       , new Menu { Name = "Ev Əşyaları", Url = "#" }
                       , new Menu { Name = "Moda", Url = "#" });

                    context.SaveChanges();
                };

                if (!context.SubMenus.Any())
                {
                    context.SubMenus.AddRange(
                         new SubMenu { Name = "Telefonlar", Url = "#", MenuId = 1 }
                       , new SubMenu { Name = "Mobil Aksesuarlar", Url = "#", MenuId = 1 }
                       , new SubMenu { Name = "Tv və Audio", Url = "#", MenuId = 1 }
                       , new SubMenu { Name = "Kompüter", Url = "#", MenuId = 2 }
                       , new SubMenu { Name = "Periferiya Qurğuları", Url = "#", MenuId = 2 }
                       , new SubMenu { Name = "Kompüter Ehtiyyat Hissələri", Url = "#", MenuId = 2 }
                       , new SubMenu { Name = "Tabletlər ücün Üzlüklər", Url = "#", MenuId = 2 }
                       , new SubMenu { Name = "Şəbəkə Avadanlıqları", Url = "#", MenuId = 2 }
                       , new SubMenu { Name = "Oyun", Url = "#", MenuId = 3 }
                       , new SubMenu { Name = "Foto", Url = "#", MenuId = 4 }
                       , new SubMenu { Name = "Mətbəxt Avadanlıqları", Url = "#", MenuId = 5 }
                       , new SubMenu { Name = "Məişət Avadanlıqları", Url = "#", MenuId = 5 }
                       , new SubMenu { Name = "Gözəllik Məhsulları", Url = "#", MenuId = 5 }
                       , new SubMenu { Name = "Ətriyyat", Url = "#", MenuId = 6 }
                       , new SubMenu { Name = "Beauty & Health", Url = "#", MenuId = 6 }
                       , new SubMenu { Name = "Tekstil", Url = "#", MenuId = 7 }
                       , new SubMenu { Name = "Koridor", Url = "#", MenuId = 7 }
                       , new SubMenu { Name = "Hamam Otağı", Url = "#", MenuId = 7 }
                       , new SubMenu { Name = "Qab-qacaq", Url = "#", MenuId = 7 }
                       , new SubMenu { Name = "Camaşırxana", Url = "#", MenuId = 7 });
                    context.SaveChanges();
                }
            }
        }
    }
}
