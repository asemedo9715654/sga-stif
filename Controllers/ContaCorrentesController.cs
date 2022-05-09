using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;

namespace sga_stif.Controllers
{
  public class ContaCorrentesController : BaseController
  {

    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public ContaCorrentesController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }

    //sem filtro
    public async Task<IActionResult> ListaQuotasVencidas()
    {
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
      var d = _context.ContaCorrenteIFResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1, @status='QV'").ToList();

      return View(d);
    }

    //filtro instituicao financeira
    [HttpGet]
    public async Task<IActionResult> ListaQuotasPendente(int? instituicaoFinanceira)
    {
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      var lista = new List<ContaCorrenteIFResultado>();

      if (instituicaoFinanceira != null)
      {

        lista = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @idif = {instituicaoFinanceira}, @status='QN'").ToList();

      }
      else
      {
        lista = _context.ContaCorrenteIFResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @status='QN'").ToList();

      }

      return View(lista);
    }

    //filtro ano e mes
    [HttpGet]
    public async Task<IActionResult> ListaQuotasPorPagar(DateTime? DataPesquisa, int? IdInstituicaoFinanceira)
    {


      var ano = DateTime.Now.Year;
      var mes = DateTime.Now.Month;

      if (DataPesquisa != null)
      {
        ano = DataPesquisa.Value.Year;
        mes = DataPesquisa.Value.Month;

      }

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;


       var d = new List<ContaCorrenteIFResultado>();


      //var d = _context.ContaCorrenteIFResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=4, @status='QD'").ToList();


       if (IdInstituicaoFinanceira != null)
      {
        d = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@idif = {IdInstituicaoFinanceira}, @status='QD'").ToList();
      }
      else
      {
        d = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes}, @status='QD'").ToList();

      }

      return View(d);
    }


    // filtro ano e mes 
    [HttpGet]
    public async Task<IActionResult> ListaQuotasPagas(DateTime? DataPesquisa, int? IdInstituicaoFinanceira)
    {
      var ano = DateTime.Now.Year;
      var mes = DateTime.Now.Month;

      if (DataPesquisa != null)
      {
        ano = DataPesquisa.Value.Year;
        mes = DataPesquisa.Value.Month;

      }

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      var d = new List<ContaCorrenteIFResultado>();

      if (IdInstituicaoFinanceira != null)
      {
        d = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@idif = {IdInstituicaoFinanceira}, @status='QP'").ToList();
      }
      else
      {
        d = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes}, @status='QP'").ToList();

      }

      return View(d);
    }


    public IActionResult EfectuaPagamento(int idQuotaSocio)
    {
      var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == idQuotaSocio);
      if (quotaSocio != null)
      {

        quotaSocio.Estado = EstadoQuotaSocio.AguardaConfirmacaoPagamento;

        quotaSocio.DataQueFoiEfectuadaPagamento = DateTime.Now;
        quotaSocio.UtilizadorQueEfectuouPagamento = PegarNomeUtilizador();


        _context.Update(quotaSocio);
        _context.SaveChanges();

        _notyf.Success("Quota posta em estado aguarda confirmacao!");

        return RedirectToAction("ListaQuotasPendente");
      }

      _notyf.Error("Quota não encontrada!");

      return RedirectToAction("ListaQuotasPendente");
    }

    public IActionResult ConcluirPagamento(int idQuotaSocio)
    {
      var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == idQuotaSocio);
      if (quotaSocio != null)
      {

        quotaSocio.Estado = EstadoQuotaSocio.Pago;
        quotaSocio.DataQueFoiConfirmadaPagamento = DateTime.Now;
        quotaSocio.UtilizadorQueConfirmouPagamento = PegarNomeUtilizador();

        _context.Update(quotaSocio);
        _context.SaveChanges();

        _notyf.Success("Pagamento confirmado com sucesso!");

        return RedirectToAction("ListaQuotasPendente");
      }

      _notyf.Error("Quota não encontrada!");

      return RedirectToAction("ListaQuotasPendente");
    }


    public IActionResult AnulaPagamento(int idQuotaSocio)
    {
      var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == idQuotaSocio);
      if (quotaSocio != null)
      {

        quotaSocio.Estado = EstadoQuotaSocio.NoaPago;
        quotaSocio.DataQueFoiConfirmadaPagamento = DateTime.Now;
        quotaSocio.UtilizadorQueConfirmouPagamento = PegarNomeUtilizador();

        _context.Update(quotaSocio);
        _context.SaveChanges();

        _notyf.Success("Pagamento anulado com sucesso!");

        return RedirectToAction("ListaQuotasPendente");
      }

      _notyf.Error("Erro : Quota sócio não encontrada!");

      return RedirectToAction("ListaQuotasPagas");
    }

    // mmultiplos select
    [HttpPost]
    public IActionResult PagamentosMultiplos(int[] IdQuotasSociosParaPagar)
    {

      int totalPostaEmAguardaConfirmacao = 0, confirmado = 0;

      foreach (var item in IdQuotasSociosParaPagar)
      {
        var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == item);
        if (quotaSocio != null)
        {

          if (quotaSocio.Estado == EstadoQuotaSocio.NoaPago)
          {
            quotaSocio.Estado = EstadoQuotaSocio.AguardaConfirmacaoPagamento;
            totalPostaEmAguardaConfirmacao++;
          }
          else if (quotaSocio.Estado == EstadoQuotaSocio.AguardaConfirmacaoPagamento)
          {
            quotaSocio.Estado = EstadoQuotaSocio.Pago;
            confirmado++;
          }

          quotaSocio.Estado = EstadoQuotaSocio.Pago;

          quotaSocio.DataQueFoiConfirmadaPagamento = DateTime.Now;
          quotaSocio.UtilizadorQueConfirmouPagamento = PegarNomeUtilizador();

          _context.Update(quotaSocio);
          _context.SaveChanges();


        }

      }

      _notyf.Success($"Operacao efectuada co sucesso :Aguarda Confirmacao - {totalPostaEmAguardaConfirmacao} --- Confirmado -{confirmado} !");

      return RedirectToAction("ListaQuotasPendente");
    }








  }
}