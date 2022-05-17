using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;

namespace sga_stif.Controllers
{
  public class PosicaoIFsController : BaseController
  {

    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public PosicaoIFsController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }

    //sem filtro
    public async Task<IActionResult> PosicaoDasInstituicoesFinanceiras()
    {
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      var lista = _context.PosicaoIFsResultado.FromSqlRaw($"EXECUTE  [dbo].[PosicaoIFs] @ano = {2022}, @mes={1}").ToList();


      return View(lista);
    }


  }
}