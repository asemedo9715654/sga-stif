using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Pagamento;

namespace sga_stif.Controllers
{
  public class PagamentoController : BaseController
  {
    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;
    public PagamentoController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }

    [HttpGet]
    public IActionResult NovoPagamento(int idQuotaSocio)
    {
      var quotaSocio = _context.QuotaSocio.Where(h => h.IdQuotaSocio == idQuotaSocio)

      .Include(j => j.Socio).ThenInclude(a=>a.Agencia).ThenInclude(i=>i.Cidade)
      .Include(j => j.Socio).ThenInclude(a=>a.Agencia).ThenInclude(i=>i.InstituicaoFinanceira)
      .Include(j => j.Socio).ThenInclude(a=>a.Agencia).ThenInclude(i=>i.Cidade).ThenInclude(J=>J.Ilha)
      .FirstOrDefault();

      if (quotaSocio != null)
      {

        DadosPagamentoViewModel dadosPagamentoViewModel = new DadosPagamentoViewModel()
        {
          Apelido = quotaSocio.Socio.Apelido,
          IdQuotaSocio = quotaSocio.IdQuotaSocio,
          Nome = quotaSocio.Socio.Nome,
          InstitucaoFinanceira = quotaSocio.Socio.Agencia.InstituicaoFinanceira.Nome,
          Agencia = quotaSocio.Socio.Agencia.Nome,
          Cidade = quotaSocio.Socio.Agencia.Cidade.Nome,
          Ilha = quotaSocio.Socio.Agencia.Cidade.Ilha.Nome,
        };

        return View(dadosPagamentoViewModel);

      }

      return RedirectToAction("ListaQuotasPendente","ContaCorrentes");
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> NovoPagamento([Bind("IdQuotaSocio,Nome,Apelido,InstitucaoFinanceira,Agencia,Ilha,Cidade,Montante")] DadosPagamentoViewModel dadosPagamentoViewModel)
    {

      try
      {

        if (ModelState.IsValid)
        {

          var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == dadosPagamentoViewModel.IdQuotaSocio);
          if (quotaSocio != null)
          {

            quotaSocio.Estado = EstadoQuotaSocio.AguardaConfirmacaoPagamento;
            quotaSocio.Montante = dadosPagamentoViewModel.Montante;

            quotaSocio.DataQueFoiEfectuadaPagamento = DateTime.Now;
            quotaSocio.UtilizadorQueEfectuouPagamento = PegarNomeUtilizador();
            quotaSocio.DataAtualizacao = DateTime.Now;

            _context.Update(quotaSocio);
            _context.SaveChanges();

            _notyf.Success("Quota posta em estado aguarda confirmacção!");

            return RedirectToAction("ListaQuotasPendente","ContaCorrentes");

          }

        }

      }
      catch (DbUpdateException ex)
      {
        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
      }

      _notyf.Error("Pagamento sem sucesso");

      return View(dadosPagamentoViewModel);
    }



    public IActionResult ConcluirPagamento(int idQuotaSocio)
    {
      var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == idQuotaSocio);
      if (quotaSocio != null)
      {

        quotaSocio.Estado = EstadoQuotaSocio.Pago;
        quotaSocio.DataQueFoiConfirmadaPagamento = DateTime.Now;
        quotaSocio.UtilizadorQueConfirmouPagamento = PegarNomeUtilizador();
        quotaSocio.DataAtualizacao = DateTime.Now;

        _context.Update(quotaSocio);
        _context.SaveChanges();

        _notyf.Success("Pagamento confirmado com sucesso!");

        return RedirectToAction("ListaQuotasPagas","ContaCorrentes");

      }

      _notyf.Error("Quota não encontrada!");

        return RedirectToAction("ListaQuotasPagas","ContaCorrentes");
    }


    public IActionResult AnularPagamento(int idQuotaSocio)
    {
      var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == idQuotaSocio);
      if (quotaSocio != null)
      {

        quotaSocio.Estado = EstadoQuotaSocio.NoaPago;
        quotaSocio.DataQueFoiConfirmadaPagamento = DateTime.Now;
        quotaSocio.UtilizadorQueConfirmouPagamento = PegarNomeUtilizador();
        quotaSocio.DataAtualizacao = DateTime.Now;

        _context.Update(quotaSocio);
        _context.SaveChanges();

        _notyf.Success("Pagamento anulado com sucesso!");

         return RedirectToAction("ListaQuotasVencidas","ContaCorrentes");
      }

      _notyf.Error("Quota não encontrada!");

      return RedirectToAction("ListaQuotasVencidas","ContaCorrentes");
    }


    [HttpPost]
    public IActionResult AnularMultiplosPagamento(int[] IdQuotasSociosParaPagar)
    {

      int anulado = 0;

      foreach (var item in IdQuotasSociosParaPagar)
      {
        var quotaSocio = _context.QuotaSocio.FirstOrDefault(k => k.IdQuotaSocio == item);
        if (quotaSocio != null)
        {
          anulado++;

          quotaSocio.Estado = EstadoQuotaSocio.NoaPago;
          quotaSocio.Montante = 0;

          quotaSocio.DataQueFoiConfirmadaPagamento = DateTime.Now;
          quotaSocio.UtilizadorQueConfirmouPagamento = PegarNomeUtilizador();

          _context.Update(quotaSocio);
          _context.SaveChanges();

        }

      }

      _notyf.Success($"Operação efectuada com sucesso : {anulado} pagamento(s) anulados : !");

      return RedirectToAction("ListaQuotasPendente","ContaCorrentes");
    }


  }
}