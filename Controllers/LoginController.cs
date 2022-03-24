using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using sga_stif.Models;
using sga_stif.ViewModel;
using BC = BCrypt.Net.BCrypt;

namespace sga_stif.Controllers
{
  public class LoginController : Controller
  {


    private readonly ContextoBaseDados _context;
     private readonly INotyfService _notyf;

    public LoginController(ContextoBaseDados context,INotyfService notyf)
    {
      _context = context;
      _notyf = notyf;
    }
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Index(LoginViewModel loginViewModel)
    {

      if (ModelState.IsValid)
      {
        var utilizador = Authenticate( loginViewModel);

        if (loginViewModel.NomeUtilizador != null && loginViewModel.PalavraPasse != null &&  utilizador != null)
        {

          _notyf.Success("seja benvindo ao sga-stif");

          //caregar variaveis de sessão
          HttpContext.Session.SetString("NomeUtilizador", loginViewModel.NomeUtilizador);
          HttpContext.Session.SetString("NomeCompleto", utilizador.PegarNomeCompleto());
          HttpContext.Session.SetString("IdUtilizador", utilizador.IdUtilizador.ToString());
          




          return RedirectToAction("ListaUtilizador", "Utilizador");

        }
        else
        {
          _notyf.Error("Dados Incorrecto");
          return View(loginViewModel);
        }
      }

      _notyf.Error("Dados Incorrecto");

      return View(loginViewModel);
    }


    [Route("logout")]
    [HttpGet]
    public IActionResult Logout()
    {
      HttpContext.Session.Remove("NomeUtilizador");
      HttpContext.Session.Remove("NomeCompleto");
      HttpContext.Session.Remove("IdUtilizador");

      return RedirectToAction("Index");
    }


    public Utilizador Authenticate(LoginViewModel model)
        {
            // get account from database
            var utilizador = _context.Utilizador.SingleOrDefault(x => x.NomeUtilizador == model.NomeUtilizador);

            // check account found and verify password
            if (utilizador == null || !BC.Verify(model.PalavraPasse, utilizador.PalavraPasse))
            {
                // authentication failed
                return null;
            }
            else
            {
                // authentication successful
                return utilizador;
            }
        }

  }
}