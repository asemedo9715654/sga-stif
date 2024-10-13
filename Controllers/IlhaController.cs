using AspNetCoreHero.ToastNotification.Abstractions;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
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
            var ilhas = _context.Ilha.AsNoTracking().Where(e => e.Eliminado == false).Include(g => g.Cidade).ThenInclude(g => g.Agencia).ToList();
            var listaIlhaViewModel = _mapper.Map<ListaIlhaViewModel>(ilhas);
            return View(listaIlhaViewModel);
        }

        public IActionResult EnvioDeEmailPorIlha(int idIlha)
        {

            ViewBag.NomeIlha = _context.Ilha.FirstOrDefault(d => d.IdIlha == idIlha).Nome;
            var emailViewModel = new EmailIlhaViewModel()
            {
                IdIlha = idIlha
            };
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
                    var ilha = _context.Ilha.AsNoTracking().FirstOrDefault(e => e.Eliminado == false && e.IdIlha == emailViewModel.IdIlha);

                    if (ilha == null)
                    {
                        _notyf.Error("Erro : Ilha não encontrada!");
                        return View(emailViewModel);
                    }

                    var socios = ilha.ObterSocios();
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
                    return RedirectToAction("ListaInstituicaoFinanceira");


                }
                _notyf.Error("Model invalido");
            }
            catch (Exception e)
            {
                _notyf.Error("Erro : " + e.Message);
            }

            ViewBag.NomeIlha = _context.Ilha.FirstOrDefault(d => d.IdIlha == emailViewModel.IdIlha).Nome;
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
