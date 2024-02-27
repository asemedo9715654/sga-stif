using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;


namespace sga_stif.ViewComponents
{
    public class NavigationMenuSideViewComponent : ViewComponent
    {

        private readonly ContextoBaseDados _context;

        public NavigationMenuSideViewComponent(ContextoBaseDados context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var idPerfil = int.Parse(HttpContext.Session.GetString("IdPerfil").ToString());
            var menu = new List<Menu>();
            var items = await _context.Menu.Include(j => j.MenuAcao).ThenInclude(k => k.PerfilMenuAcao).ToListAsync();

            foreach (var item in items)
            {
                var menuAcao = _context.MenuAcao.FirstOrDefault(j => j.IdMenu == item.IdMenu);

                if (menuAcao != null)
                {

                    var perfilMenuAcao = _context.PerfilMenuAcao.FirstOrDefault(i => i.IdPPerfil == idPerfil && menuAcao.IdMenuAcao == i.IdMenuAcao);
                    if (perfilMenuAcao != null)
                    {
                        menu.Add(item);
                    }

                }
            }
            return View(menu);
        }

    }
}