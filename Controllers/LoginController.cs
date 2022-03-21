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

        if (loginViewModel.NomeUtilizador != null && loginViewModel.PalavraPasse != null &&  Authenticate( loginViewModel))
        {
           _notyf.Success("seja benvindo ao sga-stif");

          HttpContext.Session.SetString("NomeUtilizador", loginViewModel.NomeUtilizador);
          return RedirectToAction("Index", "Utilizador");

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
      return RedirectToAction("Index");
    }


    public bool Authenticate(LoginViewModel model)
        {
            // get account from database
            var account = _context.Utilizador.SingleOrDefault(x => x.NomeUtilizador == model.NomeUtilizador);

            // check account found and verify password
            if (account == null || !BC.Verify(model.PalavraPasse, account.PalavraPasse))
            {
                // authentication failed
                return false;
            }
            else
            {
                // authentication successful
                return true;
            }
        }

  }
}