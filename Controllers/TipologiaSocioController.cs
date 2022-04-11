using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.TipologiaSocio;
using sga_stif.ViewModel.TipoQuota;

namespace sga_stif.Controllers
{
  public class TipologiaSocioController : Controller
  {

    private readonly ContextoBaseDados _context;

    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public TipologiaSocioController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaTipologiaSocio()
    {
      var tipologiaSocio = await _context.TipologiaSocio.Include(g=>g.Socio).ToListAsync();
      var listaTipologiaSocioViewModel = _mapper.Map<List<ListaTipologiaSocioViewModel>>(tipologiaSocio);
      return View(listaTipologiaSocioViewModel);
    }

  }
}