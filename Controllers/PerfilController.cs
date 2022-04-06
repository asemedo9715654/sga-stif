using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Perfil;
using sga_stif.ViewModel.Utilizador;

namespace sga_stif.Controllers
{
    public class PerfilController : Controller
    {
        private readonly ContextoBaseDados _context;

        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;



        public PerfilController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
        }



        public async Task<IActionResult> ListaPerfil()
        {
            var perfil = await _context.Perfil.ToListAsync();
            var listaPerfilViewModels = _mapper.Map<List<ListaPerfilViewModel>>(perfil);

            return View(listaPerfilViewModels);
        }



        [HttpGet]
        public IActionResult NovoPerfil()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoPerfil([Bind("Descricao")] Perfil perfil)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    _context.SaveChanges();
                    _notyf.Success("Perfil adicionado com sucesso!");
                    return RedirectToAction("ListaPerfil");
                }

                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var ee = 2;

            }
            catch (DbUpdateException /* ex */)
            {
                ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists " + "see your system administrator.");
            }

            _notyf.Error("Erro na adição de perfil");

            return View(perfil);
        }


        [HttpGet]
        public IActionResult EditaPerfil(int? idPerfil)
        {

            if (idPerfil == null)
            {
                return NotFound();
            }


            var perfil = _context.Perfil.FirstOrDefault(t => t.IdPerfil == idPerfil);

            if (perfil != null)
            {

                var editaPerfilViewModels = _mapper.Map<EditaPerfilViewModel>(perfil);

                return View(editaPerfilViewModels);

            }

            _notyf.Error("Perfil não encontrado!");

            return RedirectToAction("ListaPerfil");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditaPerfil([Bind("IdPerfil,Nome,Descricao")] EditaPerfilViewModel editaPerfilViewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    var perfil = _mapper.Map<Perfil>(editaPerfilViewModel);


                    perfil.DataAtualizacao = DateTime.Now;

                    _context.Update(perfil);
                    _context.SaveChanges();
                    _notyf.Success("Perfil editado com sucesso!");
                    return RedirectToAction("ListaPerfil");
                }

                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var ee = 2;

            }
            catch (DbUpdateException /* ex */)
            {
                ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists " + "see your system administrator.");
            }

            _notyf.Error("Erro na atualização de perfil");

            return View(editaPerfilViewModel);
        }




        public async Task<IActionResult> GerirMenuAcao(int idPerfil)
        {

            var perfil = _context.Perfil.FirstOrDefault(p => p.IdPerfil == idPerfil);
            if (perfil != null)
            {
                ViewBag.NomePerfil = perfil.Descricao;
                ViewBag.IdPerfil = perfil.IdPerfil;
            }
            else
            {
                ViewBag.NomePerfil = "Sem Perfil";
            }


            var menuAcao = await _context.MenuAcao.Where(t => t.Eliminado == false)
            .Include(c => c.Menu)
            .Include(c => c.Acao)
            .ToListAsync();


            var listaMenuAcaoViewModel = _mapper.Map<List<ListaMenuAcaoViewModel>>(menuAcao);


            return View(listaMenuAcaoViewModel);
        }



        [HttpPost]
        public JsonResult Guarda(int idPerfil, int idMenuAcao)
        {

            var perfilMenuAcao = _context.PerfilMenuAcao.FirstOrDefault(a => a.IdPPerfil == idPerfil && a.IdMenuAcao == idMenuAcao);
            if (perfilMenuAcao != null)
            {

                _context.PerfilMenuAcao.Remove(perfilMenuAcao);
                _context.SaveChanges();

            }
            else
            {
                var perfilMenuAcaoNovo = new PerfilMenuAcao()
                {
                    IdMenuAcao = idMenuAcao,
                    IdPPerfil = idPerfil
                };


                _context.PerfilMenuAcao.Add(perfilMenuAcaoNovo);
                _context.SaveChanges();
            }
            return Json(new object());

        }


        [HttpGet]
        public JsonResult GerarAcaoMaster()
        {

            var menus = _context.Menu.ToList();

            foreach (var item in menus)
            {
                var a = new Acao()
                {
                    Nome = item.Nome,
                    AcaoMaster = true
                };

                _context.Acao.Add(a);
                _context.SaveChanges();


                var menuAcao = new MenuAcao()
                {
                    IdAcao = a.IdAcao,
                    IdMenu = item.IdMenu,
                    MenuAcaoMaster = true,
                    
                };

                _context.MenuAcao.Add(menuAcao);
                _context.SaveChanges();

            }

            return Json(2);

        }


        ///outros 
        public async Task<IActionResult> ListaUtilizadorPorPerfil(int idPerfil, string nomePerfil)
        {


            ViewBag.NomePerfil = nomePerfil;



            var utilizadores = await _context.Utilizador.Where(t => t.Eliminado == false && t.IdPerfil == idPerfil).Include(c => c.Perfil).ToListAsync();
            var listaUtilizadorViewModels = _mapper.Map<List<ListaUtilizadorViewModel>>(utilizadores);

            return View(listaUtilizadorViewModels);
        }





    }
}