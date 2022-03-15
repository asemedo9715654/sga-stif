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

  }
}