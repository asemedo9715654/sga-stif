using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;
using sga_stif.ViewModel.Socio;
using sga_stif.Extensao;

namespace sga_stif.Controllers
{
  public class SocioController : BaseController
  {


    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;

    public SocioController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }



    public async Task<IActionResult> ListaSocio()
    {
      // var socios = await _context.Socio.Where(r => r.Eliminado != true).Include(c => c.Agencia)
      //                             .Include(c => c.TipologiaSocio)
      //                             .Include(c => c.TipoQuota)
      //                             .Include(c => c.Beneficiario)
      //                             .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
      //                             .ToListAsync();



      var sociosdd = await _context.Socio.Where(r => r.Eliminado != true).Include(c => c.Agencia)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.TipoQuota)
                                  .Include(c => c.Beneficiario)
                                  .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira).Select(

                                    k => new ListaSocioViewModel{
                                      IdSocio = k.IdSocio,
                                      NumeroDeSocio = k.NumeroDeSocio,
                                      NomeCompleto = k.NomeCompleto(),
                                      CinBi = k.CinBi,
                                      Sexo = k.Sexo.GetDescription(),
                                      TotalBeneficiario = k.TotalBeneficiario(),
                                      IdAgencia = k.IdAgencia,
                                      SiglaInstitucaoFinanceira = k.Agencia.InstituicaoFinanceira.SiglaFormatado(),
                                      NomeAgencia = k.Agencia.Nome



                                    }
                                  )
                                  .ToListAsync();

     // var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

    
      //return View(sociocc);
      return View(sociosdd);
    }

    public async Task<IActionResult> ListaSocioInativos()
    {
      var socios = await _context.Socio.Where(r => r.Eliminado == true).Include(c => c.Agencia)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.TipoQuota)
                                  .Include(c => c.Beneficiario)
                                  .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
                                  .ToListAsync();

      var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

      return View(sociocc);
    }

    [HttpGet]
    public IActionResult NovoSocio()
    {
      var angencia = _context.Agencia.Where(r => r.Eliminado == false).Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.Where(r => r.Eliminado == false).ToList();
      var tipoQuotas = _context.TipoQuota.Where(r => r.Eliminado == false).ToList();

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false).ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Cidade.Nome + " - " + g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };

      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> NovoSocio([Bind("Nome,NumeroDeTelemovel,NumeroDeTelefone,Email,DataDeNascimento,Sexo,Apelido,CinBi,NumeroPassaporte,ValidadePassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif,DataAtivacao,ValidadeCinBi,EstadoCivil,NumeroDeSocio,NumeroColaborador,HabilitacaoLiteraria")] NovoSocioViewModel novoSocioViewModel, IFormFile? Image = null)
    {
      byte[] p1 = null;

      try
      {
        if (ModelState.IsValid)
        {

          if (Image != null)
          {
            if (Image.Length > 0)
            {

              //byte[] p1 = null;
              using (var fs1 = Image.OpenReadStream())
              using (var ms1 = new MemoryStream())
              {
                fs1.CopyTo(ms1);
                p1 = ms1.ToArray();
              }
              //novoSocioViewModel.Foto = p1;

            }
          }

          var socio = _mapper.Map<Socio>(novoSocioViewModel);
          socio.Foto = p1;
          //socio.NumeroColaborador = "0";

          _notyf.Success("Sócio adicionado com sucesso!");

          //socio.GerarNumeroSocio();
          socio.TransformacaoSocio();

          _context.Socio.Add(socio);
          await _context.SaveChangesAsync();
          return RedirectToAction("ListaSocio");
        }

      }
      catch (DbUpdateException ex)
      {
        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
        throw;
      }

      _notyf.Error("Erro na inserção de sócio!");


      var angencia = _context.Agencia.Where(r => r.Eliminado == false).Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.Where(r => r.Eliminado == false).ToList();
      var tipoQuotas = _context.TipoQuota.Where(r => r.Eliminado == false).ToList();
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(r => r.Eliminado == false).ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;


      return View(novoSocioViewModel);
    }

    [HttpGet]
    public IActionResult EditaSocio(int idSocio, int idAgencia)
    {

      var agenciaAtul = _context.Agencia.Where(y => y.IdAgencia == idAgencia).Include(j => j.InstituicaoFinanceira).FirstOrDefault();

      var angencia = _context.Agencia.Where(j => j.IdInstituicaoFinanceira == agenciaAtul.IdInstituicaoFinanceira).Include(j => j.Cidade).ToList();

      var tipologiaSocios = _context.TipologiaSocio.Where(r => r.Eliminado == false).ToList();
      var tipoQuotas = _context.TipoQuota.Where(r => r.Eliminado == false).ToList();

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Cidade.Nome + " - " + g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };

      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome, Selected = g.IdInstituicaoFinanceira == agenciaAtul.IdInstituicaoFinanceira ? true : false };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      var socio = _context.Socio.FirstOrDefault(s => s.IdSocio == idSocio);

      var editaSocioViewModel = _mapper.Map<EditaSocioViewModel>(socio);

      return View(editaSocioViewModel);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditaSocio([Bind("IdSocio,Nome,NumeroDeTelemovel,NumeroDeTelefone,Email,DataDeNascimento,Sexo,Apelido,CinBi,NumeroPassaporte,ValidadePassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif,DataAtivacao,ValidadeCinBi,EstadoCivil,NumeroDeSocio,NumeroColaborador,HabilitacaoLiteraria")] EditaSocioViewModel editaSocioViewModel/*, IFormFile Image*/)
    {

      try
      {
        if (ModelState.IsValid)
        {

          var socio = _mapper.Map<Socio>(editaSocioViewModel);
          socio.Foto=null;
          _notyf.Success("Sócio editado com sucesso!");
          socio.DataAtualizacao = DateTime.Now;
          _context.Update(socio);
          await _context.SaveChangesAsync();
          return RedirectToAction("ListaSocio");
        }


        IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
        var ee = 2;

      }
      catch (DbUpdateException ex)
      {
        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
        throw;
      }

      _notyf.Error("Erro na edição de Sócio!");


      var angencia = _context.Agencia.Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.ToList();
      var tipoQuotas = _context.TipoQuota.ToList();
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;


      return View(editaSocioViewModel);
    }


    [HttpGet]
    public async Task<IActionResult> DetalhesSocio(int idSocio)
    {
      var socios = await _context.Socio.Where(j => j.IdSocio == idSocio)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.Beneficiario)
                                  .Include(c => c.TipoQuota)
                                   .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
                                  .Include(c => c.Agencia).ThenInclude(c => c.Cidade).ThenInclude(c => c.Ilha).FirstOrDefaultAsync();


      var destalhesSocioViewModel = _mapper.Map<DestalhesSocioViewModel>(socios);


      destalhesSocioViewModel.ListaContaCorrenteSocioResultado_Pagas = PegarContaCorrenteSocioResultado(DateTime.Now.Year, idSocio, "QP");
      destalhesSocioViewModel.ListaContaCorrenteSocioResultado_PorPagar = PegarContaCorrenteSocioResultado(DateTime.Now.Year, idSocio, "QD");
      destalhesSocioViewModel.ListaContaCorrenteSocioResultado_Vencidas = PegarContaCorrenteSocioResultado(DateTime.Now.Year, idSocio, "QV");
      destalhesSocioViewModel.ListaContaHistorialSocioResultadoHistorial = PegarContaHistorialSocioResultado(DateTime.Now.Year , idSocio);

      return View(destalhesSocioViewModel);
    }

    private List<ContaCorrenteSocioResultado> PegarContaCorrenteSocioResultado(int ano, int idSocio, string status)
    {

      var listaContaCorrenteSocioResultado = _context.ContaCorrenteSocioResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteSocio] @ano = " + ano + ", @idSocio=" + idSocio + ",@user =" + PegarNomeUtilizador() + ", @status='" + status + "'").ToList();

      return listaContaCorrenteSocioResultado;

    }


    private List<ContaHistorialSocioResultado> PegarContaHistorialSocioResultado(int ano, int idSocio)
    {

      var listaContaHistorialSocioResultado = _context.ContaHistorialSocioResultado.FromSqlRaw($"[dbo].[ContaHistorialSocio] @ano = {ano}, @idSocio = {idSocio}, @status = N'QH'").ToList();

      return listaContaHistorialSocioResultado;

    }

    public async Task<IActionResult> InativarSocio(int? idSocio)
    {
      if (idSocio == null)
      {
        return NotFound();
      }
      var socio = await _context.Socio.FirstOrDefaultAsync(m => m.IdSocio == idSocio);


      var socios = await _context.Socio.Where(j => j.IdSocio == idSocio)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.Beneficiario)
                                  .Include(c => c.TipoQuota)
                                  .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
                                  .Include(c => c.Agencia).ThenInclude(c => c.Cidade).ThenInclude(c => c.Ilha).FirstOrDefaultAsync();


      var destalhesSocioViewModel = _mapper.Map<DestalhesSocioViewModel>(socios);

      return View(destalhesSocioViewModel);
    }



    // POST: Employees/Delete/1
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> InativarSocio(int idSocio)
    {
      var socio = await _context.Socio.FindAsync(idSocio);
      socio.Eliminado = true;
      await _context.SaveChangesAsync();
      _notyf.Success("Sócio Inativado com sucesso!");


      return RedirectToAction("ListaSocio");
    }



     public async Task<IActionResult> ReativarSocio(int idSocio)
    {
      var perfil = await _context.Socio.FindAsync(idSocio);
      perfil.Eliminado = false;
      perfil.DataAtualizacao = DateTime.Now;

      await _context.SaveChangesAsync();
      _notyf.Success("Sócio reativado com sucesso!");


      return RedirectToAction("ListaSocio");
    }



    [HttpGet]
    public JsonResult PegarAgencia(int idInstituicaoFinanceira)
    {

      var perfilMenuAcao = _context.Agencia.Where(a => a.IdInstituicaoFinanceira == idInstituicaoFinanceira && a.Eliminado == false).ToList();

      var dadosAgencia = from g in perfilMenuAcao select new { g.IdAgencia, g.Nome };

      return Json(dadosAgencia);

    }



    #region validações
    [AcceptVerbs("GET", "POST")]
    public IActionResult VereficaCniBi(string CinBi)
    {
      var socio = _context.Socio.FirstOrDefault(k => k.CinBi == CinBi);
      if (socio != null)
      {
        return Json($"O CNI/BI {CinBi} já foi inserida no sistema!");
      }

      return Json(true);
    }


    [AcceptVerbs("GET", "POST")]
    public IActionResult VereficaNumeroPassaporte(string NumeroPassaporte)
    {
      var socio = _context.Socio.FirstOrDefault(k => k.NumeroPassaporte == NumeroPassaporte);
      if (socio != null)
      {
        return Json($"O Número de Passaporte {NumeroPassaporte} já foi inserida no sistema!");
      }

      return Json(true);
    }

    [AcceptVerbs("GET", "POST")]
    public IActionResult VereficaEmail(string Email)
    {
      var socio = _context.Socio.FirstOrDefault(k => k.Email == Email);
      if (socio != null)
      {
        return Json($"O E-mail : {Email} já foi inserida no sistema!");
      }

      return Json(true);
    }

    #endregion




    public async Task<IActionResult> RakingSocio()
    {

      var lista = _context.RakingSocioResultado.FromSqlRaw($"EXECUTE  [dbo].[RakingSocio]").ToList();


      return View(lista);
    }


  }
}