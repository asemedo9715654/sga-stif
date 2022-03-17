using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;

namespace sga_stif.Controllers
{
    public class PerfilController : Controller
    {
        private readonly ContextoBaseDados _context;



        public PerfilController(ContextoBaseDados context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            return View(await _context.Perfil.ToListAsync());
        }



        [HttpGet]
        public IActionResult Create()
        {
        
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Descricao")] Perfil perfil)
        {

            try
            {
                perfil.Utilizador = new List<Utilizador>();
                
                if (ModelState.IsValid)
                {
                    _context.Perfil.Add(perfil);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
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

            return View(perfil);
        }

    }
}