using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.TipoQuota;

namespace sga_stif.Controllers
{
  public class TipoQuotaController : Controller
  {

    private readonly ContextoBaseDados _context;

    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public TipoQuotaController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaTipoQuota()
    {
      var utilizadores = await _context.TipoQuota.ToListAsync();
      var listaUtilizadorViewModels = _mapper.Map<List<ListaTipoQuotaViewModel>>(utilizadores);
      return View(listaUtilizadorViewModels);
    }

  }
}