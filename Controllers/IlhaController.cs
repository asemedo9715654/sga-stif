using AspNetCoreHero.ToastNotification.Abstractions;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MimeKit;

using sga_stif.Helper;
using sga_stif.Models;
using sga_stif.ViewModel.Ilha;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.Socio;

namespace sga_stif.Controllers
{
    public class IlhaController : BaseController
    {
        public readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;
        private readonly ILogger<IlhaController> _logger;

        public IlhaController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, ILogger<IlhaController> logger)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _logger = logger;
        }
        public IActionResult ListaIlhas()
        {
            var ilhas = _context.Ilha.AsNoTracking().Where(e => e.Eliminado == false).Include(g => g.Cidade).ThenInclude(g => g.Agencia).ThenInclude(g=> g.Socio).ToList();
            var listaIlhaViewModel = _mapper.Map<List<ListaIlhaViewModel>>(ilhas);
            return View(listaIlhaViewModel);
        }

        [HttpGet]
        public IActionResult EnvioDeEmailPorIlha(int idIlha)
        {

            ViewBag.NomeIlha = _context.Ilha.FirstOrDefault(d => d.IdIlha == idIlha).Nome;
            var emailViewModel = new EmailIlhaViewModel()
            {
                IdIlha = idIlha
            };

			var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
			var instituicaoFinanceirasSelectLista = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
			ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasSelectLista;
			return View(emailViewModel);
        }

        [HttpPost]
        public IActionResult EnvioDeEmailPorIlha(EmailIlhaViewModel emailViewModel)
        {
            try
            {
                List<string> toAddress = new List<string>();
                if (ModelState.IsValid)
                {
                    var ilha = _context.Ilha.AsNoTracking().Include(i => i.Cidade).ThenInclude(i=>i.Agencia).ThenInclude(y=>y.Socio).FirstOrDefault(e => e.Eliminado == false && e.IdIlha == emailViewModel.IdIlha);

                    if (ilha == null)
                    {
                        _notyf.Error("Erro : Ilha não encontrada!");
                        return View(emailViewModel);
                    }

                    var socios = ilha.ObterSocios();
                    socios = emailViewModel.FiltrarSocio(socios, emailViewModel.Sexo);
                    socios = emailViewModel.FiltrarSocioPorInstituicaoFinanceira(socios);
                    
                    if (socios == null)
                    {
                        _notyf.Error("Erro : 0 sócio encontrado!");
                        return View(emailViewModel);
                    }

                    var lista = new List<Socio>();

                    foreach (var socio in socios)
                        if (IsValidEmail(socio.Email))
                        {
                            lista.Add(socio);
                        }

                    var listssss = from soc in lista select new EmailEnviado(soc, emailViewModel);

                    _context.EmailEnviado.AddRange(listssss);
                    _context.SaveChanges();

                    _notyf.Success("Email enviado com sucesso!");
                    return RedirectToAction("ListaIlhas");


                }
                _notyf.Error("Model invalido");
            }
            catch (Exception e)
            {
                _notyf.Error("Erro : " + e.Message);
            }

            ViewBag.NomeIlha = _context.Ilha.FirstOrDefault(d => d.IdIlha == emailViewModel.IdIlha).Nome;

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
            var instituicaoFinanceirasSelectLista = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasSelectLista;

            return View(emailViewModel);
        }

        public IActionResult EnvioDeEmailTodasIlha()
        {
            var emailViewModel = new EmailTodasIlhaViewModel()
            {
               
            };
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
            var instituicaoFinanceirasSelectLista = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasSelectLista;

            return View(emailViewModel);
        }

        [HttpPost]
        public IActionResult EnvioDeEmailTodasIlha(EmailTodasIlhaViewModel emailViewModel)
        {

			var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
			var instituicaoFinanceirasSelectLista = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
			ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasSelectLista;
			try
            {
                List<string> toAddress = new List<string>();
                if (ModelState.IsValid)
                {
                    var socios = _context.Socio.AsNoTracking().Include(a=>a.Agencia).Where(e => e.Eliminado == false ).ToList();
  
                    socios = emailViewModel.FiltrarSocioPorRegiao(socios, emailViewModel.Regiao);
                    socios = emailViewModel.FiltrarSocioPorInstituicaoFinanceira(socios);

                    if (socios == null)
                    {
						_notyf.Error("Erro : (0) sócio encontrado!");
                        return View(emailViewModel);
                    }

                    var lista = new List<Socio>();

                    foreach (var socio in socios)
                        if (IsValidEmail(socio.Email))
                        {
                            lista.Add(socio);
                        }

                    var listssss = from soc in lista select new EmailEnviado(soc, emailViewModel);

                    _context.EmailEnviado.AddRange(listssss);
                    _context.SaveChanges();

                    _notyf.Success("Email enviado com sucesso!");
                    return RedirectToAction("ListaIlhas");


                }
                _notyf.Error("Model invalido");
            }
            catch (Exception e)
            {
                _notyf.Error("Erro : " + e.Message);
            }
           
            return View(emailViewModel);
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
                return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
