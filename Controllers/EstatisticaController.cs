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

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(e => e.Eliminado == false).Include(g => g.Agencia).Select(j=>new{Sigla =j.Sigla,Agencia= j.Agencia}).ToList();

      var todos = _context.Socio.Where(e => e.Eliminado == false).Select(k=>k.IdAgencia).ToList();

      foreach (var instituicaoFinanceira in instituicaoFinanceiras)
      {
        var agencia = from j in instituicaoFinanceira.Agencia select j.IdAgencia;

        agencia.Contains(3);

        var total = todos.Where(a => agencia.Contains(a)).Count();

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

      var tipologiaSocios = _context.TipologiaSocio.Where(e => e.Eliminado == false).ToList();

      var todos = _context.Socio.Select(j=>j.IdTipologiaSocio).ToList();

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

      var tipoQuotas = _context.TipoQuota.Where(e => e.Eliminado == false).ToList();

      var todos = _context.Socio.Select(k=>k.IdTipoQuota).ToList();

      foreach (var ittipoQuota in tipoQuotas)
      {

        var total = todos.Where(a => a == ittipoQuota.IdTipoQuota).Count();

        highChartSeries.data.Add(new data()
        {
          selected = ittipoQuota.Descricao == "Mensal" ? true : false,
          sliced = ittipoQuota.Descricao == "Mensal" ? true : false,
          name = ittipoQuota.Descricao,
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

      var todos = _context.Socio.Where(e => e.Eliminado == false).Select(j=>j.Sexo).ToList();

      var lista = new List<Sexo>(){
          Sexo.Feminino,
          Sexo.Masculino
      };

      foreach (var item in lista)
      {

        var total = todos.Where(a => a == item).Count();

        highChartSeries.data.Add(new data()
        {
          selected = item == Sexo.Masculino ? true : false,
          sliced = item == Sexo.Masculino ? true : false,
          name = item.GetDescription(),
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

      var todos = _context.Socio.Where(e => e.Eliminado == false).Select(k=>k.EstadoCivil).ToList();

      var listaEstadoCivil = new List<EstadoCivil>(){
         EstadoCivil.Casado,
         EstadoCivil.Solteiro,
         EstadoCivil.SeparacaoJudicial,
         EstadoCivil.Viuvo,
         EstadoCivil.Divorciado
      };

      foreach (var estadoCivil in listaEstadoCivil)
      {

        var total = todos.Where(a => a == estadoCivil).Count();

        highChartSeries.data.Add(new data()
        {
          selected = estadoCivil == EstadoCivil.Casado ? true : false,
          sliced = estadoCivil == EstadoCivil.Casado ? true : false,
          name = estadoCivil.GetDescription(),
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

      var ilhas = _context.Ilha.Where(e => e.Eliminado == false).Include(g => g.Cidade).ThenInclude(g => g.Agencia).ToList();

      var todos = _context.Socio.Where(e=>e.Eliminado==false).Select(k=>k.IdAgencia).ToList();

      foreach (var item in ilhas)
      {

        List<int> agencia = new List<int>();

        foreach (var ilha in item.Cidade)
        {

          var idAgencias = from j in ilha.Agencia select j.IdAgencia;
          agencia.AddRange(idAgencias);

        }

        var total = todos.Where(a => agencia.Contains(a)).Count();

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

    public ActionResult OcorenciaPorSexoTacadoComInstituicaoFinanceira()
    {

      GraficoColunaEmpilhadaAgrupada graficoColunaEmpilhadaAgrupada = new GraficoColunaEmpilhadaAgrupada();

      graficoColunaEmpilhadaAgrupada.dados = new List<Dados>();


      var socios = _context.Socio.Where(e => e.Eliminado == false).Select(a=>new {a.IdAgencia,a.Sexo}).ToList();
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(e => e.Eliminado == false).Include(g => g.Agencia).ToList();
      var aux = from v in instituicaoFinanceiras select v.Sigla;
      graficoColunaEmpilhadaAgrupada.categorias = aux.ToList();



      var sexos = new List<Sexo>(){
          Sexo.Feminino,
          Sexo.Masculino
      };


      foreach (var sexo in sexos)
      {
        Dados d = new Dados();
        d.name = sexo.GetDescription();
        d.data = new List<int>();


        foreach (var instituicaoFinanceira in instituicaoFinanceiras)
        {
          var agencia = from j in instituicaoFinanceira.Agencia select j.IdAgencia;

          var total = socios.Where(a => agencia.Contains(a.IdAgencia) && a.Sexo == sexo).Count();

          d.data.Add(total);

        }

        graficoColunaEmpilhadaAgrupada.dados.Add(d);

      }

      return Json(graficoColunaEmpilhadaAgrupada);


    }

    /// iddadde
    public ActionResult OcorenciaPorSexoTacadoComIIdade()
    {

      GraficoColunaEmpilhadaAgrupada graficoColunaEmpilhadaAgrupada = new GraficoColunaEmpilhadaAgrupada();

      graficoColunaEmpilhadaAgrupada.dados = new List<Dados>();
      graficoColunaEmpilhadaAgrupada.categorias = new List<string>();


      var socios = _context.Socio.Where(e => e.Eliminado == false).ToList();
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(e => e.Eliminado == false).Include(g => g.Agencia).ToList();
      var aux = from v in instituicaoFinanceiras select v.Sigla;




      var sexos = new List<Sexo>(){
          Sexo.Feminino,
          Sexo.Masculino
      };

      var listaDeIdades = new List<int>(){
        25,29,34,39,44,49,54,59,60
      };

      int anterio = 0;

      foreach (var item in listaDeIdades)
      {
        if (item == 25)
        {
          graficoColunaEmpilhadaAgrupada.categorias.Add($"< {item}");

        }

        else if (item == 60)
        {
          graficoColunaEmpilhadaAgrupada.categorias.Add($"{item} < ");

        }
        else
        {
          graficoColunaEmpilhadaAgrupada.categorias.Add($"[{anterio} : {item}]");

        }

        anterio = item+1;
      }

      anterio = 0;

      foreach (var sexo in sexos)
      {
        Dados d = new Dados();
        d.name = sexo.GetDescription();
        d.data = new List<int>();

        foreach (var idade in listaDeIdades)
        {
          var total = 0;

          if(idade ==60){
             total = socios.Where(a => a.PegarIdade() > idade && a.Sexo == sexo).Count();

          }else{
             total = socios.Where(a => a.PegarIdade() >= anterio && a.PegarIdade() <= idade && a.Sexo == sexo).Count();
          }

          anterio = idade+1;

          if (sexo == Sexo.Feminino)
          {
            total *= -1;

          }
          d.data.Add(total);

        }

        graficoColunaEmpilhadaAgrupada.dados.Add(d);

      }

      return Json(graficoColunaEmpilhadaAgrupada);


    }



  }


}