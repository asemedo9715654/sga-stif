using AspNetCoreHero.ToastNotification.Abstractions;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using sga_stif.Models;
using sga_stif.ViewModel.Perfil;
using sga_stif.ViewModel.Utilizador;

namespace sga_stif.Controllers
{
    public class PerfilController : BaseController
    {
        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;
        private readonly ILogger<ContaCorrentesController> _logger;
        public PerfilController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, ILogger<ContaCorrentesController> logger)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IActionResult> ListaPerfil()
        {
            var perfil = await _context.Perfil.AsNoTracking().Where(h => h.Eliminado == false).Include(g => g.Utilizador).ToListAsync();
            var listaPerfilViewModels = _mapper.Map<List<ListaPerfilViewModel>>(perfil);
            return View(listaPerfilViewModels);
        }


        public async Task<IActionResult> ListaPerfilInativo()
        {
            var perfil = await _context.Perfil.AsNoTracking().Where(h => h.Eliminado == true).Include(g => g.Utilizador).ToListAsync();
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
        public async Task<IActionResult> NovoPerfil([Bind("Nome,Descricao")] NovoPerfilViewModel novoPerfilViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var perfil = _mapper.Map<Perfil>(novoPerfilViewModel);
                    _context.Perfil.Add(perfil);
                    await _context.SaveChangesAsync();
                    _notyf.Success("Perfil adicionado com sucesso!");
                    return RedirectToAction("ListaPerfil");
                }
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            _notyf.Error("Erro na adição de perfil");

            return View(novoPerfilViewModel);
        }


        [HttpGet]
        public IActionResult EditaPerfil(int? idPerfil)
        {

            if (idPerfil == null)
                return NotFound();

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
        public async Task<IActionResult> EditaPerfil([Bind("IdPerfil,Nome,Descricao")] EditaPerfilViewModel editaPerfilViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var perfil = _mapper.Map<Perfil>(editaPerfilViewModel);
                    perfil.DataAtualizacao = DateTime.Now;
                    _context.Update(perfil);
                    await _context.SaveChangesAsync();
                    _notyf.Success("Perfil editado com sucesso!");
                    return RedirectToAction("ListaPerfil");
                }
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
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
                ViewBag.NomePerfil = "Sem Perfil";


            var menuAcao = await _context.MenuAcao.Where(t => t.Eliminado == false)
            .Include(c => c.Menu)
            .Include(c => c.Acao)
            .ToListAsync();

            var listaMenuAcaoViewModel = _mapper.Map<List<ListaMenuAcaoViewModel>>(menuAcao);
            return View(listaMenuAcaoViewModel);
        }

        public async Task<IActionResult> GerirPerfilInstituicaoFinanceira(int idPerfil)
        {

            var perfil = _context.Perfil.FirstOrDefault(p => p.IdPerfil == idPerfil);
            if (perfil != null)
            {
                ViewBag.NomePerfil = perfil.Descricao;
                ViewBag.IdPerfil = perfil.IdPerfil;
            }
            else
                ViewBag.NomePerfil = "Sem Perfil";


            var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
            foreach (var instituicaoFinanceira in instituicaoFinanceiras)
            {
                var existe = _context.PerfilInstituicaoFinanceira.Any(j => j.IdPerfil == idPerfil && j.IdInstituicaoFinanceira == instituicaoFinanceira.IdInstituicaoFinanceira);
                if (!existe)
                {
                    var t = new PerfilInstituicaoFinanceira()
                    {
                        IdInstituicaoFinanceira = instituicaoFinanceira.IdInstituicaoFinanceira,
                        IdPerfil = idPerfil,
                        Permitido = true
                    };
                    _context.PerfilInstituicaoFinanceira.Add(t);
                    _context.SaveChanges();
                }

            }

            var perfilInstituicaoFinanceiras = await _context.PerfilInstituicaoFinanceira.Where(t => t.Eliminado == false && t.IdPerfil == idPerfil)
                .Include(c => c.Perfil)
                .Include(c => c.InstituicaoFinanceira)
                .ToListAsync();

            var listaPerfilInstituicaoFinanceiras = _mapper.Map<List<ListaPerfilInstituicaoFinanceiraViewModel>>(perfilInstituicaoFinanceiras);
            return View(listaPerfilInstituicaoFinanceiras);
        }

        [HttpPost]
        public JsonResult GuardaPerfilInstituicaoFinanceira(int idPerfil, int idInstituicaoFinanceira)
        {

            var perfilInstituicaoFinanceira = _context.PerfilInstituicaoFinanceira.FirstOrDefault(a => a.IdPerfil == idPerfil && a.IdInstituicaoFinanceira == idInstituicaoFinanceira);
            if (perfilInstituicaoFinanceira != null)
            {
                if (perfilInstituicaoFinanceira.Permitido == false)
                {
                    perfilInstituicaoFinanceira.Permitido = true;
                }
                else
                {
                    perfilInstituicaoFinanceira.Permitido = false;
                }
                _context.PerfilInstituicaoFinanceira.Update(perfilInstituicaoFinanceira);
                _context.SaveChanges();
            }

            return Json(new object());
        }


        public async Task<IActionResult> GerirMenuAcaoV1(int idPerfil)
        {

            var perfil = _context.Perfil.FirstOrDefault(p => p.IdPerfil == idPerfil);
            if (perfil != null)
            {
                ViewBag.NomePerfil = perfil.Descricao;
                ViewBag.IdPerfil = perfil.IdPerfil;
            }
            else
                ViewBag.NomePerfil = "Sem Perfil";
              

            var menuAcaoMasters = await _context.MenuAcao.Where(t => t.Eliminado == false && t.MenuAcaoMaster == true)
            .Include(c => c.Menu)
            .Include(c => c.Acao)
            .ToListAsync();

            var listaMenuAcaoViewModelV1 = new List<ListaMenuAcaoViewModelV1>();

            foreach (var menuAcaoMaster in menuAcaoMasters)
            {

                var ListaMenuAcaoViewModelV1aux = new ListaMenuAcaoViewModelV1();
                var menuAcaos = await _context.MenuAcao.Where(t => t.Eliminado == false && t.MenuAcaoMaster == false && t.IdMenu == menuAcaoMaster.IdMenu)
                  .Include(c => c.Menu)
                  .Include(c => c.Acao)
                  .ToListAsync();

                ListaMenuAcaoViewModelV1aux.Descricao = menuAcaoMaster.Menu.Nome;
                ListaMenuAcaoViewModelV1aux.IdMenuAcao = menuAcaoMaster.IdMenuAcao;
                ListaMenuAcaoViewModelV1aux.ListaMenuAcaoViewModelV1Helper = new List<ListaMenuAcaoViewModelV1Helper>();

                foreach (var menuAcao in menuAcaos)
                    ListaMenuAcaoViewModelV1aux.ListaMenuAcaoViewModelV1Helper.Add(new ListaMenuAcaoViewModelV1Helper(menuAcao.Acao.Nome, menuAcao.IdMenuAcao));
                listaMenuAcaoViewModelV1.Add(ListaMenuAcaoViewModelV1aux);
            }

            return View(listaMenuAcaoViewModelV1);
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
                var perfilMenuAcaoNovo = new PerfilMenuAcao(idMenuAcao, idPerfil);
                _context.PerfilMenuAcao.Add(perfilMenuAcaoNovo);
                _context.SaveChanges();
            }
            return Json(new object());
        }

        public async Task<IActionResult> ListaUtilizadorPorPerfil(int idPerfil, string nomePerfil)
        {
            ViewBag.NomePerfil = nomePerfil;
            var utilizadores = await _context.Utilizador.Where(t => t.Eliminado == false && t.IdPerfil == idPerfil).Include(c => c.Perfil).ToListAsync();
            var listaUtilizadorViewModels = _mapper.Map<List<ListaUtilizadorViewModel>>(utilizadores);

            return View(listaUtilizadorViewModels);
        }

        //validadcoes
        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNome(string Nome)
        {
            var utilizaddor = _context.Perfil.FirstOrDefault(k => k.Nome == Nome);
            if (utilizaddor != null)
                return Json($"O Nome : {Nome} já foi inserida no sistema!");

            return Json(true);
        }


        ///
        public async Task<IActionResult> InativarPerfil(int? idPerfil)
        {
            if (idPerfil == null)
                return NotFound();
            var utilizador = await _context.Perfil.FirstOrDefaultAsync(m => m.IdPerfil == idPerfil);

            var inativarPerfilViewModel = _mapper.Map<InativarPerfilViewModel>(utilizador);
            return View(inativarPerfilViewModel);
        }



        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InativarPerfil(int idPerfil)
        {
            var perfil = await _context.Perfil.FindAsync(idPerfil);
            if (perfil != null) perfil.Eliminado = true;

            await _context.SaveChangesAsync();
            _notyf.Success("Perfil inativado com sucesso!");


            return RedirectToAction("ListaPerfil");
        }

        public async Task<IActionResult> ReativarPerfil(int idPerfil)
        {
            var perfil = await _context.Perfil.FindAsync(idPerfil);
            if (perfil != null)
            {
                perfil.Eliminado = false;
                perfil.DataAtualizacao = DateTime.Now;
            }
            await _context.SaveChangesAsync();
            _notyf.Success("Perfil reativado com sucesso!");
            return RedirectToAction("ListaPerfil");
        }

    }
}