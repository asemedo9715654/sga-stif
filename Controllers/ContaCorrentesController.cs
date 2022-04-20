using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;


namespace sga_stif.Controllers
{
  public class ContaCorrentesController : Controller
  {

    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public ContaCorrentesController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaQuotasVencidas()
    {
       var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
      var d = _context.ListaQuotasVencidasResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1, @status='QV'").ToList();

      return View(d);
    }


    public async Task<IActionResult> ListaQuotasPendente()
    {
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      var d = _context.ListaQuotasVencidasResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=1, @status='QN'").ToList();

      return View(d);
    }


    public async Task<IActionResult> ListaQuotasPorPagar()
    {

       var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
      var d = _context.ListaQuotasVencidasResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=4, @status='QD'").ToList();

      return View(d);
    }



    public async Task<IActionResult> ListaQuotasPagas()
    {

       var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;
      var d = _context.ListaQuotasVencidasResultado.FromSqlRaw("EXECUTE  [dbo].[ContaCorrenteIF] @ano = 2022, @mes=4, @status='QP'").ToList();

      return View(d);
    }


  }
}