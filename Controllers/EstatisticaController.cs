using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Estatistica;

namespace sga_stif.Controllers
{
  public class EstatisticaController : Controller
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
      var socios = _context.Socio.ToList();

      ViewBag.TotalSocios = socios.Count();
      ViewBag.SocioInativos = socios.Where(g => g.Eliminado == true).Count();
      ViewBag.SocioAtivos = socios.Where(g => g.Eliminado == false).Count();


      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      ViewBag.TotalInstituicaoFinanceiras = instituicaoFinanceiras.Count();


      var agencia = _context.Agencia.ToList();
      ViewBag.TotalAgencia = agencia.Count();

      return View();
    }

    public ActionResult OcorenciaPorInstituicaoFinanceira()
    {

      HighChartSeries highChartSeries = new HighChartSeries();
      highChartSeries.name = "Sócio por Instituição Financeira";
      highChartSeries.colorByPoint = true;
      highChartSeries.data = new List<data>();

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(e=>e.Eliminado==false).Include(g => g.Agencia).ToList();

      var todos = _context.Socio.Where(e=>e.Eliminado==false).ToList();

      foreach (var instituicaoFinanceira in instituicaoFinanceiras)
      {
        var agencia = from j in instituicaoFinanceira.Agencia select j.IdAgencia;

        agencia.Contains(3);

        var total = todos.Where(a => agencia.Contains(a.IdAgencia)).Count();

        highChartSeries.data.Add(new data()
        {
          selected = instituicaoFinanceira.Sigla == "BCA" ? true : false,
          sliced = instituicaoFinanceira.Sigla == "BCA" ? true : false,
          name = instituicaoFinanceira.Sigla,
          y = total
        });

      }

      List<HighChartSeries> highChartSeriesLista = new List<HighChartSeries>();
      highChartSeriesLista.Add(highChartSeries);
      return Json(highChartSeriesLista);

    }


    public ActionResult OcorenciaPorTipologiaDeSocio()
    {

      HighChartSeries highChartSeries = new HighChartSeries();
      highChartSeries.name = "Sócio por Tipológia";
      highChartSeries.colorByPoint = true;
      highChartSeries.data = new List<data>();

      var r = _context.TipologiaSocio.Where(e=>e.Eliminado==false).ToList();

      var todos = _context.Socio.ToList();

      foreach (var item in r)
      {


        var total = todos.Where(a => a.IdTipologiaSocio == item.IdTipologiaSocio).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item.Descricao == "Normal" ? true : false,
          sliced = item.Descricao == "Normal" ? true : false,
          name = item.Descricao,
          y = total
        });

      }

      List<HighChartSeries> highChartSeriesLista = new List<HighChartSeries>();
      highChartSeriesLista.Add(highChartSeries);
      return Json(highChartSeriesLista);

    }

    public ActionResult OcorenciaPorTipoQuota()
    {

      HighChartSeries highChartSeries = new HighChartSeries();
      highChartSeries.name = "Sócio por Tipo Quota";
      highChartSeries.colorByPoint = true;
      highChartSeries.data = new List<data>();

      var r = _context.TipoQuota.Where(e=>e.Eliminado==false).ToList();

      var todos = _context.Socio.ToList();

      foreach (var item in r)
      {


        var total = todos.Where(a => a.IdTipoQuota == item.IdTipoQuota).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item.Descricao == "Mensal" ? true : false,
          sliced = item.Descricao == "Mensal" ? true : false,
          name = item.Descricao,
          y = total
        });

      }

      List<HighChartSeries> highChartSeriesLista = new List<HighChartSeries>();
      highChartSeriesLista.Add(highChartSeries);
      return Json(highChartSeriesLista);

    }


    public ActionResult OcorenciaPorSexo()
    {

      HighChartSeries highChartSeries = new HighChartSeries();
      highChartSeries.name = "Sócio por Sexo";
      highChartSeries.colorByPoint = true;
      highChartSeries.data = new List<data>();

      var todos = _context.Socio.Where(e=>e.Eliminado==false).ToList();

      var lista = new List<Sexo>(){
          Sexo.Feminino,
          Sexo.Masculino
      };

      foreach (var item in lista)
      {

        var total = todos.Where(a => a.Sexo == item).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item == Sexo.Masculino ? true : false,
          sliced = item == Sexo.Masculino ? true : false,
          name = item.ToString(),
          y = total
        });

      }

      List<HighChartSeries> highChartSeriesLista = new List<HighChartSeries>();
      highChartSeriesLista.Add(highChartSeries);
      return Json(highChartSeriesLista);

    }

    public ActionResult OcorenciaPorEstadoCivil()
    {

      HighChartSeries highChartSeries = new HighChartSeries();
      highChartSeries.name = "Sócio por Estado Cívil";
      highChartSeries.colorByPoint = true;
      highChartSeries.data = new List<data>();

      var todos = _context.Socio.Where(e=>e.Eliminado==false).ToList();

      var listaEstadoCivil = new List<EstadoCivil>(){
         EstadoCivil.Casado,
         EstadoCivil.Solteiro,
         EstadoCivil.SeparacaoJudicial,
         EstadoCivil.Viuvo,
         EstadoCivil.Divorciado
      };

      foreach (var estadoCivil in listaEstadoCivil)
      {

        var total = todos.Where(a => a.EstadoCivil == estadoCivil).Count();

        highChartSeries.data.Add(new data()
        {
          selected = estadoCivil == EstadoCivil.Casado ? true : false,
          sliced = estadoCivil == EstadoCivil.Casado ? true : false,
          name = estadoCivil.ToString(),
          y = total
        });

      }

      List<HighChartSeries> highChartSeriesLista = new List<HighChartSeries>();
      highChartSeriesLista.Add(highChartSeries);
      return Json(highChartSeriesLista);

    }


    public ActionResult OcorenciaPorIlha()
    {

      HighChartSeries highChartSeries = new HighChartSeries();
      highChartSeries.name = "Sócio por ilhas";
      highChartSeries.colorByPoint = true;
      highChartSeries.data = new List<data>();

      var ilhas = _context.Ilha.Where(e=>e.Eliminado==false).Include(g => g.Cidade).ThenInclude(g => g.Agencia).ToList();

      var todos = _context.Socio.ToList();

      foreach (var item in ilhas)
      {
        
        List<int> agencia = new List<int>();

        foreach (var ilha in item.Cidade)
        {

          var idAgencias = from j in ilha.Agencia select j.IdAgencia;
          agencia.AddRange(idAgencias);

        }

        var total = todos.Where(a => agencia.Contains(a.IdAgencia)).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item.Nome == "Santiago" ? true : false,
          sliced = item.Nome == "Santiago" ? true : false,
          name = item.Nome,
          y = total
        });

      }

      List<HighChartSeries> highChartSeriesLista = new List<HighChartSeries>();
      highChartSeriesLista.Add(highChartSeries);
      return Json(highChartSeriesLista);

    }



  }


}