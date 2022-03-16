using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;

namespace sga_stif.Controllers
{
    public class UtilizadorController : Controller
    {

        private readonly ContextoBaseDados _context;

        public UtilizadorController(ContextoBaseDados context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Utilizador.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View(await _context.Utilizador.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Apelido,Foto,PalavraPasse,PalavraPasseSalt")] Utilizador utilizador)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Utilizador.Add(utilizador);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(await _context.Utilizador.ToListAsync());
        }

    }
}