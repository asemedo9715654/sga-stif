using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.Socio;
using sga_stif.ViewModel.TipoQuota;

using MailKit.Net.Smtp;
using MimeKit;

namespace sga_stif.Controllers
{
  public class InstituicaoFinanceiraController : BaseController
  {

    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public InstituicaoFinanceiraController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaInstituicaoFinanceira()
    {
      var instituicaoFinanceira = await _context.InstituicaoFinanceira.Where(e=>e.Eliminado==false).Include(i => i.Agencia).ThenInclude(k => k.Socio).ToListAsync();
      var listaInstituicaoFinanceiraViewModel = _mapper.Map<List<ListaInstituicaoFinanceiraViewModel>>(instituicaoFinanceira);
      return View(listaInstituicaoFinanceiraViewModel);
    }

      public async Task<IActionResult> ListaInstituicaoFinanceiraInativos()
    {
      var instituicaoFinanceira = await _context.InstituicaoFinanceira.Where(e=>e.Eliminado==true).Include(i => i.Agencia).ThenInclude(k => k.Socio).ToListAsync();
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

      var instituicaoFinanceira = _context.InstituicaoFinanceira.Include(h => h.InstituicaoFinanceiraColaboradores).Include(k=>k.Agencia).FirstOrDefault(i => i.IdInstituicaoFinanceira == idInstituicaoFinanceira);

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
    public IActionResult NovoInstituicaoFinanceiraColaboradores(int idInstituicaoFinanceira,string nomeInstituicaoFinanceira)
    {
      NovoInstituicaoFinanceiraColaboradoresViewModel novoInstituicaoFinanceiraColaboradoresViewModel = new NovoInstituicaoFinanceiraColaboradoresViewModel();
      novoInstituicaoFinanceiraColaboradoresViewModel.IdInstituicaoFinanceira = idInstituicaoFinanceira;

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


          var colaboradores = _context.InstituicaoFinanceiraColaboradores.Where(j=>j.IdInstituicaoFinanceira == instituicaoFinanceira.IdInstituicaoFinanceira && j.DataFim==null );
          foreach (var item in colaboradores)
          {
            item.DataFim = DateTime.Now.Date;
          }

           await _context.SaveChangesAsync();

          var instituicaoFinanceiraColaboradores = _mapper.Map<InstituicaoFinanceiraColaboradores>(novoInstituicaoFinanceiraColaboradoresViewModel);
          instituicaoFinanceiraColaboradores.DataInicio = DateTime.Now.Date;
          instituicaoFinanceiraColaboradores.DataFim = null;
          instituicaoFinanceira.InstituicaoFinanceiraColaboradores.Add(instituicaoFinanceiraColaboradores);
         
          await _context.SaveChangesAsync();
          _notyf.Success("Instituição Financeira Colaboradores adicionado com sucesso!");
          return RedirectToAction("DetalhesInstituicaoFinanceira",new{idInstituicaoFinanceira=novoInstituicaoFinanceiraColaboradoresViewModel.IdInstituicaoFinanceira});
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

      var inativarPerfilViewModel= _mapper.Map<InativarInstituicaoFinanceiraViewModel>(instituicaoFinanceira);
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

      var listaAgencias =from OKK in _context.Agencia.Where(j=>j.IdInstituicaoFinanceira == idInstituicaoFinanceira).ToList() select OKK.IdAgencia;

      ViewBag.NomeDeInstituicaoFinanceira = nomeDeInstituicaoFinanceira;

      var socios = await _context.Socio.Where(r => r.Eliminado != true &&listaAgencias.Contains(r.IdAgencia) ).Include(c => c.Agencia)
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

      ViewBag.NomeInstituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(d=>d.IdInstituicaoFinanceira==idInstituicaoFinanceira).Nome;
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
        if (ModelState.IsValid )
        {
          IEnumerable<InternetAddress> ff = new List<InternetAddress>(); 
          var ddd =  _context.Socio.Where(e=>e.Eliminado==false&&e.Agencia.IdInstituicaoFinanceira==emailViewModel.IdInstituicaoFinanceira).ToList();

          foreach (var dd in ddd)
          {
            if(IsValidEmail(dd.Email))
            {
              ff.Append(new MailboxAddress(dd.Nome, dd.Email));
            }
            
          }
          ff.Append(new MailboxAddress("jj", "vamp9278493cv@gmail.com"));
          var emailMessagedd = CreateEmailMessage(emailViewModel,ff);
          Send(emailMessagedd);
          _notyf.Success("Email enviado com sucesso!");
          return RedirectToAction("ListaInstituicaoFinanceira");
        }
        _notyf.Error("Model invalido");
      }
      catch (Exception e)
      {
        _notyf.Error("Erro : "+e.Message);
      }
      
      ViewBag.NomeInstituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(d=>d.IdInstituicaoFinanceira==emailViewModel.IdInstituicaoFinanceira).Nome;

      return View(emailViewModel);
    }
    
    bool IsValidEmail(string email)
    {
      var trimmedEmail = email.Trim();

      if (trimmedEmail.EndsWith(".")) {
        return false; // suggested by @TK-421
      }
      try {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == trimmedEmail;
      }
      catch {
        return false;
      }
    }
    
    private MimeMessage CreateEmailMessage(EmailViewModel message, IEnumerable<InternetAddress> para)
    {
      var emailMessage = new MimeMessage();
      emailMessage.From.Add(new MailboxAddress("Angelo Semedo","vamp9278493cv@gmail.com"));
      emailMessage.To.AddRange(para);
      //emailMessage.To.Add(para);
      emailMessage.Subject = message.Assunto;
      emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.CorpoDoEmail };
      return emailMessage;
    }
    private void Send(MimeMessage mailMessage)
    {
      
      var emailConfig = new EmailConfiguration()
      {
        From = "vamp9278493cv@gmail.com",
        Password = "#merda-Mundo2020",
        Port = 25,
        SmtpServer = "smtp.gmail.com",
        UserName = "vamp9278493cv@gmail.com"
      };
      
      using (var client = new SmtpClient())
      {
        try
        {
          client.Connect(emailConfig.SmtpServer, emailConfig.Port, false);
          client.AuthenticationMechanisms.Remove("XOAUTH2");
          client.Authenticate(emailConfig.UserName, emailConfig.Password);
          client.Send(mailMessage);
        }catch (Exception e)
        {
          //log an error message or throw an exception or both.
          throw new Exception(e.Message);
        }
        finally
        {
          client.Disconnect(true);
          client.Dispose();
        }
      }
    }
    

    #endregion
  }
}