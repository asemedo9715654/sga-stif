using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.MenuAcao;

namespace sga_stif.Controllers
{
    public class MenuAcaoController : BaseController
    {

        private readonly ContextoBaseDados _context;
        private readonly IMapper _mapper;

        public MenuAcaoController(ContextoBaseDados context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IActionResult> ListaMenu()
        {
            var menus = await _context.Menu.ToListAsync();
            var listaMenuViewModels = _mapper.Map<List<ListaMenuViewModel>>(menus);
            return View(listaMenuViewModels);
        }


        public async Task<IActionResult> GerirAcao(int idMenu, string nomeMenu)
        {
            ViewBag.idMenu = idMenu;
            ViewBag.NomeMenu = nomeMenu;
            var acao = await _context.Acao.Where(j=>j.AcaoMaster==false).ToListAsync();
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