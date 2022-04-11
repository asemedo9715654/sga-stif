using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.TipoQuota;

namespace sga_stif.Controllers
{
  public class AgenciaController : Controller
  {

    private readonly ContextoBaseDados _context;

    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;


    public AgenciaController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }


    public async Task<IActionResult> ListaAgencia()
    {
      var agencia = await _context.Agencia.Include(g=>g.Cidade).Include(h=>h.InstituicaoFinanceira).Include(h=>h.Socio).ToListAsync();
      var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
      return View(listaAgenciaViewModel);
    }


     public async Task<IActionResult> ListaAgenciaPorInstitucaoFinanceira(int idInstituicaoFinanceira,string nomeInstituicao)
    {

      ViewBag.NomeInstituicaoFinanceira = nomeInstituicao;
      var agencia = await _context.Agencia.Where(r=>r.IdInstituicaoFinanceira==idInstituicaoFinanceira).Include(g=>g.Cidade).Include(h=>h.InstituicaoFinanceira).Include(h=>h.Socio).ToListAsync();
      var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
      return View(listaAgenciaViewModel);
    }

  }
}