using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Socio;
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


      public async Task<IActionResult> ListaSocioPorTipologiaSocio(int idTipologiaSocio,string nome)
    {
      ViewBag.NomeTipoQuota = nome;
      
      var socios = await _context.Socio.Where(r => r.Eliminado != true && r.IdTipologiaSocio == idTipologiaSocio).Include(c => c.Agencia)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.TipoQuota)
                                  .Include(c => c.Beneficiario)
                                  .ToListAsync();

      var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

      return View(sociocc);
    }

  }
}