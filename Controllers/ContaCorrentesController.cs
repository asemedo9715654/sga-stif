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
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(a => a.Eliminado == false).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };


            var lista = new List<ContaCorrenteIFResultado>();

            if (IdInstituicaoFinanceira != null)
            {
                var valorConvertido = IdInstituicaoFinanceira.ToString();
                var selected = instituicaoFinanceirasItem.Where(x => x.Value == valorConvertido).First();
                selected.Selected = true;

                lista = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1,@idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QV'").ToList();
            }
            else
            {
                instituicaoFinanceirasItem.Append(new SelectListItem { Text = "--- todos ---", Selected = true, Disabled = true });
                lista = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1,@user ='{PegarNomeUtilizador()}', @status='QV'").ToList();
            }

            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
            return View(lista);
        }

        //filtro instituicao financeira
        [HttpGet]
        public async Task<IActionResult> ListaQuotasPendente(int? instituicaoFinanceira)
        {
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            var lista = new List<ContaCorrenteIFResultado>();

            if (instituicaoFinanceira != null)
            {

                lista = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @idif = {instituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QN'").ToList();

            }
            else
            {
                lista = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @user ='{PegarNomeUtilizador()}', @status='QN'").ToList();

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
            else
            {
                DataPesquisa = new DateTime(ano, mes, 1);
            }

            ViewBag.DataPreenchido = ano + "-" + DataPesquisa.Value.Month.ToString("#00");

            //ViewBag.DataPreenchido = ano+"-"+mes;

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;


            var d = new List<ContaCorrenteIFResultado>();


            if (IdInstituicaoFinanceira != null)
            {
                d = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QD'").ToList();
            }
            else
            {
                d = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@user ='{PegarNomeUtilizador()}', @status='QD'").ToList();

            }

            return View(d);
        }

        // filtro ano e mes 
        [HttpGet]
        public async Task<IActionResult> ListaQuotasPagas(DateTime? DataPesquisa, int? IdInstituicaoFinanceira)
        {
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;

            _logger.LogInformation($@"IdInstituicaoFinanceira : {IdInstituicaoFinanceira}");

            if (DataPesquisa != null)
            {
                ano = DataPesquisa.Value.Year;
                mes = DataPesquisa.Value.Month;
            }
            else
                DataPesquisa = new DateTime(ano, mes, 1);

            ViewBag.DataPreenchido = ano + "-" + DataPesquisa.Value.Month.ToString("#00");

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            var listContaCorrenteIFResultado = new List<ContaCorrenteIFResultado>();

            if (IdInstituicaoFinanceira != null)
                listContaCorrenteIFResultado = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@idif = {IdInstituicaoFinanceira},@user ='{PegarNomeUtilizador()}', @status='QP'").ToList();
            else
                listContaCorrenteIFResultado = _context.ContaCorrenteIFResultado.FromSqlRaw($"EXECUTE  [dbo].[ContaCorrenteIF] @ano = {ano}, @mes={mes},@user ='{PegarNomeUtilizador()}', @status='QP'").ToList();

            return View(listContaCorrenteIFResultado);
        }

    }
}