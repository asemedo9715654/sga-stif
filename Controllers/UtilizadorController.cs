using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Utilizador;

namespace sga_stif.Controllers
{
  public class UtilizadorController : Controller
  {

    private readonly ContextoBaseDados _context;

    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;

    public UtilizadorController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaUtilizador()
    {
      var utilizadores = await _context.Utilizador.Where(t => t.Eliminado == false).Include(c => c.Perfil).ToListAsync();
      var listaUtilizadorViewModels = _mapper.Map<List<ListaUtilizadorViewModel>>(utilizadores);
      return View(listaUtilizadorViewModels);
    }
    public async Task<IActionResult> ListaUtilizadorInativos()
    {
      var utilizadores = await _context.Utilizador.Where(t => t.Eliminado == true).Include(c => c.Perfil).ToListAsync();
      var listaUtilizadorViewModels = _mapper.Map<List<ListaUtilizadorViewModel>>(utilizadores);
      return View(listaUtilizadorViewModels);
    }

    [HttpGet]
    public IActionResult NovoUtilizador()
    {
      var perfils = _context.Perfil.ToList();
      var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Nome };
      ViewBag.IdPerfil = perfilr;

      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult NovoUtilizador([Bind("Nome,Apelido,Foto,PalavraPasse,PalavraPasseSalt,Email,IdPerfil,NomeUtilizador")] Utilizador utilizador, IFormFile Image)
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

          _notyf.Success("Utilizador adicionado com sucesso!");
          utilizador.PalavraPasse = BCrypt.Net.BCrypt.HashPassword(utilizador.PalavraPasse);
          _context.Utilizador.Add(utilizador);
          _context.SaveChanges();
          return RedirectToAction("ListaUtilizador");
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

      _notyf.Error("Erro na insercao de utilizador!");

      var perfils = _context.Perfil.ToList();
      var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Nome };
      ViewBag.IdPerfil = perfilr;

      return View(utilizador);
    }


    public async Task<IActionResult> EliminaUtilizador(int? idUtilizador)
    {
      if (idUtilizador == null)
      {
        return NotFound();
      }
      var utilizador = await _context.Utilizador.FirstOrDefaultAsync(m => m.IdUtilizador == idUtilizador);

      return View(utilizador);
    }



    // POST: Employees/Delete/1
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EliminaUtilizador(int idUtilizador)
    {
      var utilizador = await _context.Utilizador.FindAsync(idUtilizador);
      utilizador.Eliminado = true;
      //_context.Socio.Remove(employee);
      //_context.Socio.Remove(employee);
      await _context.SaveChangesAsync();
      _notyf.Success("Utilizador eliminado com sucesso!");


      return RedirectToAction("ListaUtilizador");
    }

  }
}