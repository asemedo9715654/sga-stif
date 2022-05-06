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
        public IActionResult NovoPagamento(int idQuotaSocio, string rotaParaRedicionar)
        {
            var quotaSocio = _context.QuotaSocio.Where(h => h.IdQuotaSocio == idQuotaSocio).Include(j => j.Socio).FirstOrDefault();

            if (quotaSocio != null)
            {

                DadosPagamentoViewModel dadosPagamentoViewModel = new DadosPagamentoViewModel()
                {
                    Apelido = quotaSocio.Socio.Apelido,
                    IdQuotaSocio = quotaSocio.IdQuotaSocio,
                    Nome = quotaSocio.Socio.Nome
                };

                return View(dadosPagamentoViewModel);

            }

            return RedirectToAction(rotaParaRedicionar);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NovoPagamento([Bind("IdQuotaSocio,Nome,Apelido,Montante")] DadosPagamentoViewModel dadosPagamentoViewModel)
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

                        _notyf.Success("Quota posta em estado aguarda confirmacao!");

                        return RedirectToAction("DetalhesSocio", new { idSocio = quotaSocio.IdSocio });
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



        public IActionResult ConcluirPagamento(int idQuotaSocio, string rotaParaRedicionar)
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

                return RedirectToAction(rotaParaRedicionar);
                //return RedirectToAction("DetalhesSocio", new { idSocio = quotaSocio.IdSocio });
            }

            _notyf.Error("Quota não encontrada!");

            return RedirectToAction(rotaParaRedicionar);
        }


        public IActionResult AnularPagamento(int idQuotaSocio, string rotaParaRedicionar)
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

                return RedirectToAction(rotaParaRedicionar);
            }

            _notyf.Error("Quota não encontrada!");

            return RedirectToAction(rotaParaRedicionar);
        }


    }
}