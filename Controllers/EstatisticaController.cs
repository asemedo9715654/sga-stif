using AspNetCoreHero.ToastNotification.Abstractions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using sga_stif.Extensao;
using sga_stif.Models;
using sga_stif.ViewModel.Estatistica;

namespace sga_stif.Controllers
{
    public class EstatisticaController : BaseController
    {

        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        public EstatisticaController(ContextoBaseDados context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }

        public IActionResult Inicio()
        {
            var socios = _context.Socio.AsNoTracking().ToList();

            ViewBag.TotalSocios = socios.Count();
            ViewBag.SocioInativos = socios.Where(g => g.Eliminado == true && ListaAgenciasPermitidas(_context).Contains(g.IdAgencia)).Count();
            ViewBag.SocioAtivos = socios.Where(g => g.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(g.IdAgencia)).Count();

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(e => ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).ToList();
            ViewBag.TotalInstituicaoFinanceiras = instituicaoFinanceiras.Count();

            var agencia = _context.Agencia.AsNoTracking().Where(r => ListaAgenciasPermitidas(_context).Contains(r.IdAgencia)).ToList();
            ViewBag.TotalAgencia = agencia.Count();

            return View();
        }

        public ActionResult OcorenciaPorInstituicaoFinanceira()
        {

            var highChartSeries = new HighChartSeries();
            highChartSeries.name = "Sócio por Instituição Financeira";
            highChartSeries.colorByPoint = true;
            highChartSeries.data = new List<data>();

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(e => e.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).Include(g => g.Agencia).Select(j => new { Sigla = j.Sigla, Agencia = j.Agencia }).ToList();

            var listaDdeSocios = _context.Socio.AsNoTracking().Where(e => e.Eliminado == false).Select(k => k.IdAgencia).ToList();

            foreach (var instituicaoFinanceira in instituicaoFinanceiras)
            {
                var agencia = from j in instituicaoFinanceira.Agencia select j.IdAgencia;
                agencia.Contains(3);

                var total = listaDdeSocios.Where(a => agencia.Contains(a)).Count();
                highChartSeries.data.Add(new data()
                {
                    selected = instituicaoFinanceira.Sigla == "BCA" ? true : false,
                    sliced = instituicaoFinanceira.Sigla == "BCA" ? true : false,
                    name = instituicaoFinanceira.Sigla,
                    y = total
                });
            }

            var highChartSeriesLista = new List<HighChartSeries>();
            highChartSeriesLista.Add(highChartSeries);
            return Json(highChartSeriesLista);

        }

        public ActionResult OcorenciaPorTipologiaDeSocio()
        {

            var highChartSeries = new HighChartSeries();
            highChartSeries.name = "Sócio por Tipológia";
            highChartSeries.colorByPoint = true;
            highChartSeries.data = new List<data>();

            var tipologiaSocios = _context.TipologiaSocio.AsSplitQuery().Where(e => e.Eliminado == false).ToList();

            var todos = _context.Socio.Where(r => r.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(r.IdAgencia)).Select(j => j.IdTipologiaSocio).ToList();

            foreach (var tipologiaSocio in tipologiaSocios)
            {

                var total = todos.Where(a => a == tipologiaSocio.IdTipologiaSocio).Count();

                highChartSeries.data.Add(new data()
                {
                    selected = tipologiaSocio.Descricao == "Normal" ? true : false,
                    sliced = tipologiaSocio.Descricao == "Normal" ? true : false,
                    name = tipologiaSocio.Descricao,
                    y = total
                });

            }

            var highChartSeriesLista = new List<HighChartSeries>();
            highChartSeriesLista.Add(highChartSeries);
            return Json(highChartSeriesLista);
        }

        public ActionResult OcorenciaPorTipoQuota()
        {
            var highChartSeries = new HighChartSeries();
            highChartSeries.name = "Sócio por Tipo Quota";
            highChartSeries.colorByPoint = true;
            highChartSeries.data = new List<data>();

            var tipoQuotas = _context.TipoQuota.AsNoTracking().Where(e => e.Eliminado == false).ToList();
            var todos = _context.Socio.AsNoTracking().Where(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia)).Select(k => k.IdTipoQuota).ToList();

            foreach (var ittipoQuota in tipoQuotas)
            {
                var total = todos.Where(a => a == ittipoQuota.IdTipoQuota).Count();
                highChartSeries.data.Add(new data(ittipoQuota, total));
            }

            var highChartSeriesLista = new List<HighChartSeries>();
            highChartSeriesLista.Add(highChartSeries);
            return Json(highChartSeriesLista);

        }

        public ActionResult OcorenciaPorSexo()
        {

            var highChartSeries = new HighChartSeries();
            highChartSeries.name = "Sócio por Sexo";
            highChartSeries.colorByPoint = true;
            highChartSeries.data = new List<data>();

            var listaDeSocio = _context.Socio.AsNoTracking().Where(e => e.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia)).Select(j => j.Sexo).ToList();

            var lista = new List<Sexo>(){
                Sexo.Feminino,
                Sexo.Masculino
            };

            foreach (var item in lista)
            {
                var total = listaDeSocio.Where(a => a == item).Count();
                highChartSeries.data.Add(new data(item, total));
            }

            var highChartSeriesLista = new List<HighChartSeries>();
            highChartSeriesLista.Add(highChartSeries);
            return Json(highChartSeriesLista);

        }

        public ActionResult OcorenciaPorEstadoCivil()
        {
            var highChartSeries = new HighChartSeries();
            highChartSeries.name = "Sócio por Estado Cívil";
            highChartSeries.colorByPoint = true;
            highChartSeries.data = new List<data>();

            var listaDeSocio = _context.Socio.AsNoTracking().Where(e => e.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia)).Select(k => k.EstadoCivil).ToList();

            var listaEstadoCivil = new List<EstadoCivil>(){
                 EstadoCivil.Casado,
                 EstadoCivil.Solteiro,
                 EstadoCivil.SeparacaoJudicial,
                 EstadoCivil.Viuvo,
                 EstadoCivil.Divorciado
             };

            foreach (var estadoCivil in listaEstadoCivil)
            {
                var total = listaDeSocio.Where(a => a == estadoCivil).Count();
                highChartSeries.data.Add(new data(estadoCivil,total));
            }

            var highChartSeriesLista = new List<HighChartSeries>();
            highChartSeriesLista.Add(highChartSeries);
            return Json(highChartSeriesLista);

        }


        public ActionResult OcorenciaPorIlha()
        {
            var highChartSeries = new HighChartSeries("Sócio por ilhas");
            var ilhas = _context.Ilha.AsNoTracking().Where(e => e.Eliminado == false).Include(g => g.Cidade).ThenInclude(g => g.Agencia).ToList();
            var listaDeSocio = _context.Socio.Where(e => e.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia)).Select(k => k.IdAgencia).ToList();
            highChartSeries.PreencherDadosIlhas(ilhas, listaDeSocio);
            var highChartSeriesLista = new List<HighChartSeries>();
            highChartSeriesLista.Add(highChartSeries);
            return Json(highChartSeriesLista);

        }

        public ActionResult OcorenciaPorSexoTacadoComInstituicaoFinanceira()
        {
            var graficoColunaEmpilhadaAgrupada = new GraficoColunaEmpilhadaAgrupada();
            var socios = _context.Socio.AsNoTracking().Where(e => e.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia)).Select(a => new { a.IdAgencia, a.Sexo }).ToList();
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(e => e.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).Include(g => g.Agencia).ToList();
            var aux = from v in instituicaoFinanceiras select v.Sigla;
            graficoColunaEmpilhadaAgrupada.categorias = aux.ToList();

            var sexos = new List<Sexo>(){
                  Sexo.Feminino,
                  Sexo.Masculino
            };

            foreach (var sexo in sexos)
            {
                var dado = new Dados
                {
                    name = sexo.PegarDescricao(),
                    data = new List<int>()
                };

                foreach (var instituicaoFinanceira in instituicaoFinanceiras)
                {
                    var agencia = from j in instituicaoFinanceira.Agencia select j.IdAgencia;
                    var total = socios.Where(a => agencia.Contains(a.IdAgencia) && a.Sexo == sexo).Count();
                    dado.data.Add(total);
                }
                graficoColunaEmpilhadaAgrupada.dados.Add(dado);
            }
            return Json(graficoColunaEmpilhadaAgrupada);
        }

        /// iddadde
        public ActionResult OcorenciaPorSexoTacadoComIIdade()
        {
            var graficoColunaEmpilhadaAgrupada = new GraficoColunaEmpilhadaAgrupada();
            var listaDeSocios = _context.Socio.AsNoTracking().Where(e => e.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia)).ToList();
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(e => e.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).Include(g => g.Agencia).ToList();
            var aux = from v in instituicaoFinanceiras select v.Sigla;

            var sexos = new List<Sexo>(){ Sexo.Feminino, Sexo.Masculino };
            var listaDeIdades = new List<int>(){ 25,29,34,39,44,49,54,59,60 };
            var anterio = 0;
            graficoColunaEmpilhadaAgrupada.AdicionarCategorias(listaDeIdades);
            graficoColunaEmpilhadaAgrupada.PreencherDados(listaDeIdades,sexos,listaDeSocios);

            return Json(graficoColunaEmpilhadaAgrupada);
        }
    }
}