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

      var r = _context.InstituicaoFinanceira.Include(g => g.Agencia).ToList();

      var todos = _context.Socio.ToList();

      foreach (var item in r)
      {
        var agencia = from j in item.Agencia select j.IdAgencia;

        agencia.Contains(3);

        var total = todos.Where(a => agencia.Contains(a.IdAgencia)).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item.Sigla == "BCA" ? true : false,
          sliced = item.Sigla == "BCA" ? true : false,
          name = item.Sigla,
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

      var r = _context.TipologiaSocio.ToList();

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

      var r = _context.TipoQuota.ToList();

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

      var todos = _context.Socio.ToList();

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

      var todos = _context.Socio.ToList();

      var lista = new List<EstadoCivil>(){
         EstadoCivil.Casado,
         EstadoCivil.Solteiro,
         EstadoCivil.SeparacaoJudicial,
         EstadoCivil.Viuvo,
         EstadoCivil.Divorciado
      };

      foreach (var item in lista)
      {

        var total = todos.Where(a => a.EstadoCivil == item).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item == EstadoCivil.Casado ? true : false,
          sliced = item == EstadoCivil.Casado ? true : false,
          name = item.ToString(),
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

      var r = _context.Ilha.Include(g => g.Cidade).ThenInclude(g => g.Agencia).ToList();

      var todos = _context.Socio.ToList();

      foreach (var item in r)
      {
        
        List<int> agencia = new List<int>();

        foreach (var h in item.Cidade)
        {

          var bb = from j in h.Agencia select j.IdAgencia;
          agencia.AddRange(bb);

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