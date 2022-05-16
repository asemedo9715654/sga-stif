using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Socio;
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
      var utilizadores = await _context.TipoQuota.Where(h=>h.Eliminado==false).Include(j=>j.Socio).ToListAsync();
      var listaUtilizadorViewModels = _mapper.Map<List<ListaTipoQuotaViewModel>>(utilizadores);
      return View(listaUtilizadorViewModels);
    }


    public async Task<IActionResult> ListaSocioPorTipoQuota(int idTipoQuota,string nome)
    {
      ViewBag.NomeTipoQuota = nome;
      
      var socios = await _context.Socio.Where(r => r.Eliminado != true && r.IdTipoQuota == idTipoQuota).Include(c => c.Agencia)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.TipoQuota)
                                   .Include(c => c.Beneficiario)
                                  .ToListAsync();

      var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

      return View(sociocc);
    }

  }
}