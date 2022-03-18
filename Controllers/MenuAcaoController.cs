using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;

namespace sga_stif.Controllers
{
    public class MenuAcaoController : Controller
    {

        private readonly ContextoBaseDados _context;

        public MenuAcaoController(ContextoBaseDados context)
        {
            _context = context;
        }


        public async Task<IActionResult> ListaMenu()
        {
            var menus = await _context.Menu.ToListAsync();
            return View(menus);
        }


        public async Task<IActionResult> GerirAcao(int idMenu, string nomeMenu)
        {
            ViewBag.idMenu = idMenu;
            ViewBag.NomeMenu = nomeMenu;
            var acao = await _context.Acao.ToListAsync();
            return View(acao);
        }

        [HttpPost]
        public JsonResult Guarda(int idAcao, int idMenu)
        {

            var perfilAacao = _context.MenuAcao.FirstOrDefault(a => a.IdAcao == idAcao && a.IdMenu == idMenu);
            if (perfilAacao != null)
            {

                _context.MenuAcao.Remove(perfilAacao);
                _context.SaveChanges();

            }
            else
            {
                var perfilAcaoExterno = new MenuAcao()
                {
                    IdMenu = idMenu,
                    IdAcao = idAcao,

                };


                _context.MenuAcao.Add(perfilAcaoExterno);
                _context.SaveChanges();
            }
            return Json(new object());

        }






    }
}