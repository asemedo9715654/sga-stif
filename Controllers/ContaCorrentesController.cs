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
        private readonly ILogger<ContaCorrentesController> _logger;
        public ContaCorrentesController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, ILogger<ContaCorrentesController> logger)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _logger = logger;
        }

        //sem filtro
        public async Task<IActionResult> ListaQuotasVencidas(int? IdInstituicaoFinanceira)
        {


            var idInstituicaoFinanceira = IdInstituicaoFinanceira ?? 0;
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(a => a.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(a.IdInstituicaoFinanceira)).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras
                                             select new SelectListItem
                                             {
                                                 Value = g.IdInstituicaoFinanceira.ToString(),
                                                 Text = g.Nome,
                                                 Selected = g.IdInstituicaoFinanceira == idInstituicaoFinanceira
                                             };

            var contaCorrenteIfResultados = new List<ContaCorrenteIFResultado>();

            if (IdInstituicaoFinanceira != null)
            {
                var valorConvertido = IdInstituicaoFinanceira.ToString();
                var selected = instituicaoFinanceirasItem.First(x => x.Value == valorConvertido);
                selected.Selected = true;

                contaCorrenteIfResultados = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1,@idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QV'").ToList();
            }
            else
            {
                instituicaoFinanceirasItem.Append(new SelectListItem { Text = "--- todos ---", Selected = true, Disabled = true });
                contaCorrenteIfResultados = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1,@user ='{PegarNomeUtilizador()}', @status='QV'").ToList();
            }

            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
            return View(contaCorrenteIfResultados);
        }

        //filtro instituicao financeira
        [HttpGet]
        public async Task<IActionResult> ListaQuotasPendente(int? IdInstituicaoFinanceira)
        {
            var idInstituicaoFinanceira = IdInstituicaoFinanceira ?? 0;

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras
                                             select new SelectListItem
                                             {
                                                 Value = g.IdInstituicaoFinanceira.ToString(),
                                                 Text = g.Nome,
                                                 Selected = g.IdInstituicaoFinanceira == idInstituicaoFinanceira
                                             };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            var contaCorrenteIfResultados = new List<ContaCorrenteIFResultado>();



            if (IdInstituicaoFinanceira != null)
            {
                contaCorrenteIfResultados = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QN'").ToList();
            }
            else
            {
                contaCorrenteIfResultados = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @user ='{PegarNomeUtilizador()}', @status='QN'").ToList();
            }

            return View(contaCorrenteIfResultados);
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
            else
            {
                DataPesquisa = new DateTime(ano, mes, 1);
            }

            ViewBag.DataPreenchido = ano + "-" + DataPesquisa.Value.Month.ToString("#00");

            var idInstituicaoFinanceira = IdInstituicaoFinanceira ?? 0;
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras
                                             select new SelectListItem
                                             {
                                                 Value = g.IdInstituicaoFinanceira.ToString(),
                                                 Text = g.Nome,
                                                 Selected = g.IdInstituicaoFinanceira == idInstituicaoFinanceira
                                             };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            var contaCorrenteIfResultados = new List<ContaCorrenteIFResultado>();

            if (IdInstituicaoFinanceira != null)
            {
                contaCorrenteIfResultados = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QD'").ToList();
            }
            else
            {
                contaCorrenteIfResultados = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@user ='{PegarNomeUtilizador()}', @status='QD'").ToList();
            }

            return View(contaCorrenteIfResultados);
        }

        // filtro ano e mes 
        [HttpGet]
        public async Task<IActionResult> ListaQuotasPagas(DateTime? DataPesquisa, int? IdInstituicaoFinanceira)
        {
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;
            var idInstituicaoFinanceira = IdInstituicaoFinanceira ?? 0;

            _logger.LogInformation($@"IdInstituicaoFinanceira : {IdInstituicaoFinanceira}");

            if (DataPesquisa != null)
            {
                ano = DataPesquisa.Value.Year;
                mes = DataPesquisa.Value.Month;
            }
            else
                DataPesquisa = new DateTime(ano, mes, 1);

            ViewBag.DataPreenchido = ano + "-" + DataPesquisa.Value.Month.ToString("#00");

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome, Selected = idInstituicaoFinanceira == g.IdInstituicaoFinanceira };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
            var listContaCorrenteIFResultado = new List<ContaCorrenteIFResultado>();

            if (IdInstituicaoFinanceira != null)
            {
                var query = $"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QP'";
                listContaCorrenteIFResultado = _context.ContaCorrenteIFResultado.FromSqlRaw(query).ToList();
            }
            else
            {
                var query = $"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@user ='{PegarNomeUtilizador()}', @status='QP'";
                listContaCorrenteIFResultado = _context.ContaCorrenteIFResultado.FromSqlRaw(query).ToList();

            }

            return View(listContaCorrenteIFResultado);
        }

    }
}