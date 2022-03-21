using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
      var T = await _context.Utilizador.Include(c => c.Perfil).ToListAsync();
      return View(T);
    }

    [HttpGet]
    public IActionResult Create()
    {
      var perfils = _context.Perfil.ToList();
      var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Descricao };
      ViewBag.IdPerfil = perfilr;

      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Nome,Apelido,Foto,PalavraPasse,PalavraPasseSalt,Email,IdPerfil,NomeUtilizador")] Utilizador utilizador, IFormFile Image)
    {

      try
      {
        if (ModelState.IsValid)
        {

          if (Image != null)

          {
            if (Image.Length > 0)

            //Convert Image to byte and save to database

            {

              byte[] p1 = null;
              using (var fs1 = Image.OpenReadStream())
              using (var ms1 = new MemoryStream())
              {
                fs1.CopyTo(ms1);
                p1 = ms1.ToArray();
              }
              utilizador.Foto = p1;

            }
          }








          utilizador.PalavraPasse = BCrypt.Net.BCrypt.HashPassword(utilizador.PalavraPasse);
          _context.Utilizador.Add(utilizador);
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


      var perfils = _context.Perfil.ToList();
      var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Descricao };
      ViewBag.IdPerfil = perfilr;

      return View(utilizador);
    }

  }
}