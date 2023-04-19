using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serilog;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;
using System.Globalization;

namespace sga_stif.Controllers
{
    public class PosicaoIFsController : BaseController
    {

        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;

        private readonly CultureInfo portuguese = new CultureInfo("pt-PT");


        public PosicaoIFsController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
        }

        //sem filtro
        public async Task<IActionResult> PosicaoDasInstituicoesFinanceiras(DateTime? DataPesquisa)
        {
            var ano = DateTime.Now.Year;
            var mes = DateTime.Now.Month;

            if (DataPesquisa != null)
            {
                ano = DataPesquisa.Value.Year;
                mes = DataPesquisa.Value.Month;
            }
            else
                DataPesquisa = new DateTime(ano, mes, 1);

            ViewBag.DataPreenchido = ano + "-" + DataPesquisa.Value.Month.ToString("#00");

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            var query = $"EXECUTE  [dbo].[PosicaoIFs] @ano = {ano}, @mes={mes}";

            Log.Information(query);

            var posicaoIFsResultados = _context.PosicaoIFsResultado.FromSqlRaw($"EXECUTE  [dbo].[PosicaoIFs] @ano = {ano}, @mes={mes}").ToList();

            ViewBag.Ano = ano;
            ViewBag.Mes = mes;
            ViewBag.MesAtual = DataPesquisa.Value.ToString("MMMM", portuguese);
            ViewBag.MesAnterior = DataPesquisa.Value.AddDays(-1).ToString("MMMM", portuguese);

            return View(posicaoIFsResultados);
        }


        public async Task<IActionResult> PosicaoDasInstituicoesFinanceirasDetalhes(int ano, int mes, int idInstituicaoFinanceira)
        {
            var dataPesquisa = new DateTime(ano, mes, 1);
            ViewBag.MesAtual = dataPesquisa.ToString("MMMM", portuguese);
            ViewBag.MesAnterior = dataPesquisa.AddDays(-1).ToString("MMMM", portuguese);
            var reconciliacaoEntreMesesResultados = _context.ReconciliacaoEntreMesesResultado.FromSqlRaw($"EXECUTE  [dbo].[ReconciliacaoEntreMeses] @ano = {ano}, @mes = {mes}, @idif = {idInstituicaoFinanceira}").ToList();
            return View(reconciliacaoEntreMesesResultados);
        }


    }
}