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

    public LoginController(ContextoBaseDados context, INotyfService notyf)
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
        var utilizador = Authenticate(loginViewModel);

        if (loginViewModel.NomeUtilizador != null && loginViewModel.PalavraPasse != null && utilizador != null)
        {

          var perfil = _context.Perfil.FirstOrDefault(k => k.IdPerfil == utilizador.IdPerfil);

          if (perfil != null)
          {

            if (perfil.Eliminado == true)
            {
              _notyf.Error("Perfil do Utilizador Inativo");
              return View(loginViewModel);

            }

            _notyf.Success("seja bem-vindo ao SGA-STIF");

            //caregar variaveis de sessão
            HttpContext.Session.SetString("NomeUtilizador", loginViewModel.NomeUtilizador);
            HttpContext.Session.SetString("NomeCompleto", utilizador.PegarNomeCompleto());
            HttpContext.Session.SetString("IdUtilizador", utilizador.IdUtilizador.ToString());
            HttpContext.Session.SetString("IdPerfil", utilizador.IdPerfil.ToString());

            HttpContext.Session.SetString("Foto", utilizador.PegarLinkFoto());


            return RedirectToAction("Inicio", "Dashboard");

          }
          else
          {
            _notyf.Error("Perfil Inexistente");
            return View(loginViewModel);

          }

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
      HttpContext.Session.Remove("IdPerfil");
      HttpContext.Session.Remove("Foto");

      return RedirectToAction("Index");
    }


    public Utilizador Authenticate(LoginViewModel model)
    {
      // get account from database
      var utilizador = _context.Utilizador.SingleOrDefault(x => x.NomeUtilizador == model.NomeUtilizador && x.Eliminado == false);

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