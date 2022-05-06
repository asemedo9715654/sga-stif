using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
      var agencia = await _context.Agencia.Include(g => g.Cidade).Include(h => h.InstituicaoFinanceira).Include(h => h.Socio).ToListAsync();
      var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
      return View(listaAgenciaViewModel);
    }


    public async Task<IActionResult> ListaAgenciaPorInstitucaoFinanceira(int idInstituicaoFinanceira, string nomeInstituicao)
    {

      ViewBag.NomeInstituicaoFinanceira = nomeInstituicao;
      var agencia = await _context.Agencia.Where(r => r.IdInstituicaoFinanceira == idInstituicaoFinanceira).Include(g => g.Cidade).Include(h => h.InstituicaoFinanceira).Include(h => h.Socio).ToListAsync();
      var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
      return View(listaAgenciaViewModel);
    }



    [HttpGet]
    public IActionResult NovaAgencia()
    {

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
      var instituicaoFinanceirasSelectLista = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      var cidades = _context.Cidade.ToList();
      var cidadesSelectLista = from g in cidades select new SelectListItem { Value = g.IdCidade.ToString(), Text = g.Nome };

      ViewBag.IdCidade = cidadesSelectLista;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasSelectLista;

      return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> NovaAgencia([Bind("Nome,IdCidade,IdInstituicaoFinanceira")] NovaAgenciaViewModel novoPerfilViewModel)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var agencia = _mapper.Map<Agencia>(novoPerfilViewModel);
          _context.Agencia.Add(agencia);
          await _context.SaveChangesAsync();
          _notyf.Success("Agencia adicionado com sucesso!");
          return RedirectToAction("ListaAgencia");
        }

      }
      catch (DbUpdateException ex)
      {

        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
      }

      _notyf.Error("Erro na adição de agencia");

      return View(novoPerfilViewModel);
    }

    [HttpGet]
    public IActionResult EditaAgencia(int idAgencia)
    {



      var agencia = _context.Agencia.FirstOrDefault(h => h.IdAgencia == idAgencia);
      if (agencia != null)
      {

        var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
        var instituicaoFinanceirasSelectLista = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

        var cidades = _context.Cidade.ToList();
        var cidadesSelectLista = from g in cidades select new SelectListItem { Value = g.IdCidade.ToString(), Text = g.Nome };

        ViewBag.IdCidade = cidadesSelectLista;
        ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasSelectLista;

          var agenciaViewModel = _mapper.Map<EditaAgenciaViewModel>(agencia);

        return View(agenciaViewModel);
      }

      _notyf.Error("Agencia Inexistente!");

       return RedirectToAction("ListaAgencia");
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditaAgencia([Bind("Nome,IdCidade,IdInstituicaoFinanceira")] NovaAgenciaViewModel novoPerfilViewModel)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var agencia = _mapper.Map<Agencia>(novoPerfilViewModel);
          _context.Agencia.Add(agencia);
          await _context.SaveChangesAsync();
          _notyf.Success("Agencia adicionado com sucesso!");
          return RedirectToAction("ListaAgencia");
        }

      }
      catch (DbUpdateException ex)
      {

        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
      }

      _notyf.Error("Erro na adição de agencia");

      return View(novoPerfilViewModel);
    }


  }
}