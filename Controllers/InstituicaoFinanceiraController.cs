using AspNetCoreHero.ToastNotification.Abstractions;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MimeKit;

using sga_stif.Helper;
using sga_stif.Models;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.Socio;


using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace sga_stif.Controllers
{
    public class InstituicaoFinanceiraController : BaseController
    {

        public readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;
        private readonly ILogger<InstituicaoFinanceiraController> _logger;

        public InstituicaoFinanceiraController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, ILogger<InstituicaoFinanceiraController> logger)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IActionResult> ListaInstituicaoFinanceira()
        {


            var instituicaoFinanceira = await _context.InstituicaoFinanceira.Where(e => e.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).Include(i => i.Agencia).ThenInclude(k => k.Socio).ToListAsync();
            var listaInstituicaoFinanceiraViewModel = _mapper.Map<List<ListaInstituicaoFinanceiraViewModel>>(instituicaoFinanceira);
            return View(listaInstituicaoFinanceiraViewModel);
        }

        public async Task<IActionResult> ListaInstituicaoFinanceiraInativos()
        {
            var instituicaoFinanceira = await _context.InstituicaoFinanceira.Where(e => e.Eliminado == true).Include(i => i.Agencia).ThenInclude(k => k.Socio).ToListAsync();
            var listaInstituicaoFinanceiraViewModel = _mapper.Map<List<ListaInstituicaoFinanceiraViewModel>>(instituicaoFinanceira);
            return View(listaInstituicaoFinanceiraViewModel);
        }


        [HttpGet]
        public IActionResult NovoInstituicaoFinanceira()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoInstituicaoFinanceira([Bind("Nome,Sigla")] NovoInstituicaoFinanceiraViewModel novoInstituicaoFinanceiraViewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var instituicaoFinanceira = _mapper.Map<InstituicaoFinanceira>(novoInstituicaoFinanceiraViewModel);
                    _context.InstituicaoFinanceira.Add(instituicaoFinanceira);
                    _context.SaveChanges();
                    _notyf.Success("instituição Financeira adicionado com sucesso!");
                    return RedirectToAction("ListaInstituicaoFinanceira");
                }

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            _notyf.Error("Erro na adição de Instituição Financeira");

            return View(novoInstituicaoFinanceiraViewModel);
        }


        [HttpGet]
        public IActionResult EditaInstituicaoFinanceira(int idInstituicaoFinanceira)
        {

            var instituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(i => i.IdInstituicaoFinanceira == idInstituicaoFinanceira);

            if (instituicaoFinanceira == null)
            {
                _notyf.Error("Instituição Financeira inexistente!");
                return RedirectToAction("ListaInstituicaoFinanceira");

            }

            var editaInstituicaoFinanceiraViewModel = _mapper.Map<EditaInstituicaoFinanceiraViewModel>(instituicaoFinanceira);

            return View(editaInstituicaoFinanceiraViewModel);
        }

        [HttpGet]
        public IActionResult DetalhesInstituicaoFinanceira(int idInstituicaoFinanceira)
        {

            var instituicaoFinanceira = _context.InstituicaoFinanceira.Include(h => h.InstituicaoFinanceiraColaboradores).Include(k => k.Agencia).FirstOrDefault(i => i.IdInstituicaoFinanceira == idInstituicaoFinanceira);

            if (instituicaoFinanceira == null)
            {
                _notyf.Error("Instituição Financeira inexistente!");
                return RedirectToAction("ListaInstituicaoFinanceira");
            }

            var editaInstituicaoFinanceiraViewModel = _mapper.Map<DetalhesInstituicaoFinanceiraViewModel>(instituicaoFinanceira);

            return View(editaInstituicaoFinanceiraViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditaInstituicaoFinanceira([Bind("IdInstituicaoFinanceira,Nome,Sigla")] EditaInstituicaoFinanceiraViewModel editaInstituicaoFinanceiraViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var instituicaoFinanceira = _mapper.Map<InstituicaoFinanceira>(editaInstituicaoFinanceiraViewModel);
                    _context.Update(instituicaoFinanceira);
                    _context.SaveChanges();
                    _notyf.Success("Instituição Financeira editado com sucesso!");
                    return RedirectToAction("ListaInstituicaoFinanceira");
                }
            }
            catch (DbUpdateException ex)
            {

                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            _notyf.Error("Erro na edição de Instituição Financeira");
            return View(editaInstituicaoFinanceiraViewModel);
        }

        //novo numero de colaboradores
        [HttpGet]
        public IActionResult NovoInstituicaoFinanceiraColaboradores(int idInstituicaoFinanceira, string nomeInstituicaoFinanceira)
        {
            var novoInstituicaoFinanceiraColaboradoresViewModel = new NovoInstituicaoFinanceiraColaboradoresViewModel
            {
                IdInstituicaoFinanceira = idInstituicaoFinanceira
            };

            ViewBag.NomeDeInstituicaoFinanceira = nomeInstituicaoFinanceira;
            return View(novoInstituicaoFinanceiraColaboradoresViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NovoInstituicaoFinanceiraColaboradores([Bind("IdInstituicaoFinanceira,NumeroColaboradores")] NovoInstituicaoFinanceiraColaboradoresViewModel novoInstituicaoFinanceiraColaboradoresViewModel)
        {

            var instituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(j => j.IdInstituicaoFinanceira == novoInstituicaoFinanceiraColaboradoresViewModel.IdInstituicaoFinanceira);

            try
            {
                if (ModelState.IsValid && instituicaoFinanceira != null)
                {
                    var colaboradores = _context.InstituicaoFinanceiraColaboradores.Where(j => j.IdInstituicaoFinanceira == instituicaoFinanceira.IdInstituicaoFinanceira && j.DataFim == null);
                    foreach (var item in colaboradores)
                    {
                        item.DataFim = DateTime.Now.Date;
                    }

                    await _context.SaveChangesAsync();

                    var instituicaoFinanceiraColaboradores = _mapper.Map<InstituicaoFinanceiraColaboradores>(novoInstituicaoFinanceiraColaboradoresViewModel);
                    instituicaoFinanceiraColaboradores.Inicializar();
                    instituicaoFinanceira.InstituicaoFinanceiraColaboradores.Add(instituicaoFinanceiraColaboradores);

                    await _context.SaveChangesAsync();
                    _notyf.Success("Instituição Financeira Colaboradores adicionado com sucesso!");
                    return RedirectToAction("DetalhesInstituicaoFinanceira", new { idInstituicaoFinanceira = novoInstituicaoFinanceiraColaboradoresViewModel.IdInstituicaoFinanceira });
                }

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            ViewBag.NomeDeInstituicaoFinanceira = instituicaoFinanceira.Nome;

            _notyf.Error("Erro na adição de perfil");

            return View(novoInstituicaoFinanceiraColaboradoresViewModel);
        }


        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNome(string Nome)
        {
            var utilizaddor = _context.InstituicaoFinanceira.FirstOrDefault(k => k.Nome == Nome);
            if (utilizaddor != null)
            {
                return Json($"O Nome da Instituição: {Nome} já foi inserida no sistema!");
            }

            return Json(true);
        }

        public async Task<IActionResult> InativarInstituicaoFinanceira(int? idInstituicaoFinanceira)
        {
            if (idInstituicaoFinanceira == null)
            {
                return NotFound();
            }
            var instituicaoFinanceira = await _context.InstituicaoFinanceira.FirstOrDefaultAsync(m => m.IdInstituicaoFinanceira == idInstituicaoFinanceira);

            var inativarPerfilViewModel = _mapper.Map<InativarInstituicaoFinanceiraViewModel>(instituicaoFinanceira);
            return View(inativarPerfilViewModel);
        }

        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InativarInstituicaoFinanceira(int idInstituicaoFinanceira)
        {
            var instituicaoFinanceira = await _context.InstituicaoFinanceira.FindAsync(idInstituicaoFinanceira);
            if (instituicaoFinanceira != null)
            {
                instituicaoFinanceira.Eliminado = true;
                instituicaoFinanceira.DataAtualizacao = DateTime.Now;
            }

            await _context.SaveChangesAsync();
            _notyf.Success("Intituição Financeira inativado com sucesso!");
            return RedirectToAction("ListaInstituicaoFinanceira");
        }

        public async Task<IActionResult> ReativarInstituicaoFinanceira(int idInstituicaoFinanceira)
        {
            var utilizador = await _context.InstituicaoFinanceira.FindAsync(idInstituicaoFinanceira);
            utilizador.Eliminado = false;
            utilizador.DataAtualizacao = DateTime.Now;

            await _context.SaveChangesAsync();
            _notyf.Success("Instituição Financeira reativado com sucesso!");


            return RedirectToAction("ListaInstituicaoFinanceira");
        }


        public async Task<IActionResult> ListaSocioPorInstituicaoFinanceira(int idInstituicaoFinanceira, string nomeDeInstituicaoFinanceira)
        {

            var listaAgencias = from OKK in _context.Agencia.Where(j => j.IdInstituicaoFinanceira == idInstituicaoFinanceira).ToList() select OKK.IdAgencia;

            ViewBag.NomeDeInstituicaoFinanceira = nomeDeInstituicaoFinanceira;

            var socios = await _context.Socio.Where(r => r.Eliminado != true && listaAgencias.Contains(r.IdAgencia)).Include(c => c.Agencia)
                                        .Include(c => c.TipologiaSocio)
                                        .Include(c => c.TipoQuota)
                                        .Include(c => c.Beneficiario)
                                        .ToListAsync();

            var listaSocioViewModel = _mapper.Map<List<ListaSocioViewModel>>(socios);

            return View(listaSocioViewModel);
        }

        #region envio de email

        public IActionResult EnvioDeEmailPorInstituicao(int idInstituicaoFinanceira)
        {

            ViewBag.NomeInstituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(d => d.IdInstituicaoFinanceira == idInstituicaoFinanceira).Nome;
            var emailViewModel = new EmailViewModel()
            {
                IdInstituicaoFinanceira = idInstituicaoFinanceira
            };
            return View(emailViewModel);
        }

        [HttpPost]
        public IActionResult EnvioDeEmailPorInstituicao(EmailViewModel emailViewModel)
        {
            try
            {
                List<string> toAddress = new List<string>();
                if (ModelState.IsValid)
                {

                    var socios = _context.Socio.AsNoTracking().Where(e => e.Eliminado == false && e.Agencia.IdInstituicaoFinanceira == emailViewModel.IdInstituicaoFinanceira).ToList();

                    socios = emailViewModel.FiltrarSocio(socios, emailViewModel.Sexo);

                    var lista = new List<Socio>();

                    foreach (var socio in socios)
                        if (IsValidEmail(socio.Email))
                        {
                            lista.Add(socio);
                        }

                    IEnumerable<Socio[]> divisaoDeQuatroArrayDeSemElementos = socios.Chunk(25);

                    var sucesso = true;
                    var mensagemSucesso = "";

                    foreach (var socioDividido in divisaoDeQuatroArrayDeSemElementos)
                    {
                        var resultadoMetodo = SendEmailMailKit(socioDividido.ToList(), emailViewModel.Assunto, emailViewModel.CorpoDoEmail);
                        if (!resultadoMetodo.Sucesso)
                        {
                            mensagemSucesso += resultadoMetodo.Mensagem;
                            sucesso = false;
                        }
                    }


                    if (sucesso)
                    {
                        _notyf.Success("Email enviado com sucesso!");
                        return RedirectToAction("ListaInstituicaoFinanceira");
                    }

                    _notyf.Error(mensagemSucesso);
                    return RedirectToAction("ListaInstituicaoFinanceira");


                }
                _notyf.Error("Model invalido");
            }
            catch (Exception e)
            {
                _notyf.Error("Erro : " + e.Message);
            }

            ViewBag.NomeInstituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(d => d.IdInstituicaoFinanceira == emailViewModel.IdInstituicaoFinanceira).Nome;
            return View(emailViewModel);
        }


        public IActionResult EnvioDeEmailTodasInstituicao()
        {
            ViewBag.NomeInstituicaoFinanceira = "Todos";
            return View();
        }


        [HttpPost]
        public IActionResult EnvioDeEmailTodasInstituicao(EmailTodosViewModel emailViewModel)
        {
            try
            {
                List<string> toAddress = new List<string>();
                if (ModelState.IsValid)
                {
                    var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(g => ListaInstituicoesFinanceirasPermitidas(_context).Contains(g.IdInstituicaoFinanceira) && g.Eliminado == false).ToList();
                    var idInstituicoes = from d in instituicaoFinanceiras select d.IdInstituicaoFinanceira;

                    var socios = _context.Socio.Where(e => e.Eliminado == false && idInstituicoes.Contains(e.Agencia.IdInstituicaoFinanceira)).ToList();

                    socios = emailViewModel.FiltrarSocio(socios, emailViewModel.Sexo);

                     var lista = new List<Socio>();

                    foreach (var socio in socios)
                        if (IsValidEmail(socio.Email))
                        {
                            lista.Add(socio);
                        }

                    var sucesso = true;
                    var mensagemSucesso = "";
                    IEnumerable<Socio[]> divisaoDeQuatroArrayDeSemElementos = socios.Chunk(25);

                    foreach (var socioDividido in divisaoDeQuatroArrayDeSemElementos)
                    {
                        var resultadoMetodo = SendEmailMailKit(socioDividido.ToList(), emailViewModel.Assunto, emailViewModel.CorpoDoEmail);
                        if (!resultadoMetodo.Sucesso)
                        {
                            mensagemSucesso += resultadoMetodo.Mensagem;
                            sucesso = false;
                        }
                    }

                    if (sucesso)
                    {
                        _notyf.Success("Email enviado com sucesso!");
                        return RedirectToAction("ListaInstituicaoFinanceira");
                    }

                    _notyf.Error(mensagemSucesso);
                    return RedirectToAction("ListaInstituicaoFinanceira");
                }
                _notyf.Error("Model invalido");
            }
            catch (Exception e)
            {
                _notyf.Error("Erro : " + e.Message);
            }

            ViewBag.NomeInstituicaoFinanceira = "Todos";
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

        //////////////////////////////
        public ResultadoMetodo<string> SendEmail(List<string> toAddress, string subject, string body)
        {
            try
            {
                //var smtpClient = new SmtpClient("mail.stif.cv", 465)
                //{
                //    EnableSsl = true,
                //    DeliveryMethod = SmtpDeliveryMethod.Network,
                //    UseDefaultCredentials = false,
                //    Credentials = new NetworkCredential("contact@stif.cv", "Cont@2023"),
                //    Timeout = 300

                //};

                //var mailMessage = new MailMessage()
                //{
                //    Subject = subject,
                //    Body = body,
                //    From = new MailAddress("contact@stif.cv"),
                //    IsBodyHtml = true,
                //};

                //foreach (var addresses in socios)
                //    mailMessage.To.Add(addresses);

                //mailMessage.To.Add("vamp9278493cv@gmail.com");
                //smtpClient.Send(mailMessage);

                return new ResultadoMetodo<string>("", "");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResultadoMetodo<string>(e);
            }

        }

        public ResultadoMetodo<string> SendEmailMailKit(List<Socio> socios, string subject, string body)
        {
            try
            {
                // Configurações do servidor SMTP
                string smtpServer = "mail.stif.cv";
                int smtpPort = 587;
                string smtpUsername = "contact@stif.cv";
                string smtpPassword = "Cont@2023";

                // Criando a mensagem de email
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("STIF", "contact@stif.cv"));
                message.Bcc.Add(new MailboxAddress("Ângelo Semedo", "vamp9278493cv@gmail.com"));
                message.Bcc.Add(new MailboxAddress("Odailton Veiga", "pachecoveiga@gmail.com"));

                //divisao de listas
                IEnumerable<Socio[]> divisaoDeQuatroArrayDeSemElementos = socios.Chunk(25);

                foreach (var socioDividido in divisaoDeQuatroArrayDeSemElementos)
                {
                    foreach (var socio in socioDividido)
                    {
                        message.Bcc.Add(new MailboxAddress(socio.Nome + " " + socio.Apelido, socio.Email));
                    }
                }

                message.Subject = subject;
                // Corpo do email
                var builder = new BodyBuilder();
                builder.HtmlBody = body;

                message.Body = builder.ToMessageBody();
                //message.HtmlBody = builder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    client.Connect(smtpServer, smtpPort, false);
                    client.Authenticate(smtpUsername, smtpPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                return new ResultadoMetodo<string>("", "");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResultadoMetodo<string>(e);
            }

        }

        #endregion
    }
}