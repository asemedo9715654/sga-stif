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
        private readonly ILogger<ContaCorrentesController> _logger;

        public LoginController(ContextoBaseDados context, INotyfService notyf, ILogger<ContaCorrentesController> logger)
        {
            _context = context;
            _notyf = notyf;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("LoginController - Index - Get");
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            _logger.LogInformation("LoginController - Index - Post");
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
                        CaregarVariaveisDeSessao(loginViewModel, utilizador);
                        return RedirectToAction("Inicio", "Dashboard");
                    }
                    _notyf.Error("Perfil Inexistente");
                    return View(loginViewModel);
                }
                _notyf.Error("Dados Incorrecto");
                return View(loginViewModel);
            }
            _notyf.Error("Dados Incorrecto");
            return View(loginViewModel);
        }

        private void CaregarVariaveisDeSessao(LoginViewModel loginViewModel, Utilizador utilizador)
        {
            HttpContext.Session.SetString("NomeUtilizador", loginViewModel.NomeUtilizador);
            HttpContext.Session.SetString("NomeCompleto", utilizador.PegarNomeCompleto());
            HttpContext.Session.SetString("IdUtilizador", utilizador.IdUtilizador.ToString());
            HttpContext.Session.SetString("IdPerfil", utilizador.IdPerfil.ToString());
            HttpContext.Session.SetString("Foto", utilizador.PegarLinkFoto());
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
            var utilizador = _context.Utilizador.SingleOrDefault(x => x.NomeUtilizador == model.NomeUtilizador && x.Eliminado == false);
            if (utilizador == null || !BC.Verify(model.PalavraPasse, utilizador.PalavraPasse))
                return null;
            return utilizador;
        }

    }
}