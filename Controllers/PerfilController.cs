using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Perfil;

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
            return View(await _context.Perfil.ToListAsync());
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
                perfil.Utilizador = new List<Utilizador>();

                if (ModelState.IsValid)
                {
                    _context.Perfil.Add(perfil);
                    _context.SaveChanges();
                    _notyf.Success("Perfil adicionado com sucesso!");
                    return RedirectToAction("ListaPerfil");
                }

                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var ee = 2;

            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }

            _notyf.Error("Erro na adicao dde perfil");

            return View(perfil);
        }




        public async Task<IActionResult> GerirMenuAcao(int idPerfil)
        {

            var perfil = _context.Perfil.FirstOrDefault(p => p.IdPerfil == idPerfil);
            if (perfil != null)
            {
                ViewBag.NomePerfil = perfil.Descricao;
                ViewBag.IdPerfil = perfil.IdPerfil;
            }else{
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





    }
}