using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

    [HttpGet]
    public IActionResult Create()
    {
      var perfils =_context.Perfil.ToList();
      var perfilr =  from g  in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Descricao }; 
      ViewBag.Perfils = perfilr;

      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Nome,Apelido,Foto,PalavraPasse,PalavraPasseSalt,Email,IdPerfil")] Utilizador utilizador)
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


      var perfils =_context.Perfil.ToList();
      var perfilr =  from g  in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Descricao }; 
      ViewBag.Perfils = perfilr;

      return View(await _context.Utilizador.ToListAsync());
    }

  }
}