using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.Monitor;
using sga_stif.ViewModel.TipoQuota;

namespace sga_stif.Controllers
{
  public class MonitorController : Controller
  {

    private readonly ContextoBaseDados _context;

    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public MonitorController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaQuotasVencidas()
    {
     var ggg = ListaQuotasVencidasViewModel.DadosFalso();
      return View(ggg);
    }


  }
}