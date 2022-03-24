using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;

namespace sga_stif.Controllers
{
    public class PerfilController : Controller
    {
        private readonly ContextoBaseDados _context;

        private readonly INotyfService _notyf;



        public PerfilController(ContextoBaseDados context,INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
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

    }
}