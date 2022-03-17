using Microsoft.AspNetCore.Mvc;
using sga_stif.ViewModel;

namespace sga_stif.Controllers
{
  public class LoginController : Controller
  {

    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Index(LoginViewModel loginViewModel)
    {

      if (ModelState.IsValid)
      {

        if (loginViewModel.NomeUtilizador != null && loginViewModel.PalavraPasse != null && loginViewModel.NomeUtilizador.Equals("angelo") && loginViewModel.PalavraPasse.Equals("123"))
        {
          HttpContext.Session.SetString("NomeUtilizador", loginViewModel.NomeUtilizador);
          return RedirectToAction("Index", "Utilizador");

        }
        else
        {
          ViewBag.error = "Invalid Account";
          return View(loginViewModel);
        }
      }

      return View(loginViewModel);
    }


    [Route("logout")]
    [HttpGet]
    public IActionResult Logout()
    {
      HttpContext.Session.Remove("NomeUtilizador");
      return RedirectToAction("Index");
    }

  }
}