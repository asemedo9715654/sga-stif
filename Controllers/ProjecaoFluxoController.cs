using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;

namespace sga_stif.Controllers
{
  public class ProjecaoFluxoController : BaseController
  {

    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public ProjecaoFluxoController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }

    //sem filtro
    public async Task<IActionResult> ListaProjecaoFluxo(int? idInstituicaoFinanceira, decimal? percentagem)
    {

      List<ProjecaoQuotasResultado> lista = new List<ProjecaoQuotasResultado>();

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(a => a.Eliminado == false).ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      if(idInstituicaoFinanceira!=null && percentagem!=null){

         ViewBag.Percentagem =percentagem;

          
          lista = _context.ProjecaoQuotasResultado.FromSqlRaw($"[dbo].[ProjecaoQuotas] @idif = {idInstituicaoFinanceira}, @perc = {percentagem}").ToList();

          var firsttt = lista.FirstOrDefault();
          if(firsttt!=null){
            ViewBag.MontanteAtualGlobal =firsttt.MontanteAtualGlobal;
            ViewBag.MontanteComProjecaoGlobal =firsttt.MontanteComProjecaoGlobal;
          }
      }

   
      return View(lista);
    }

  }
}