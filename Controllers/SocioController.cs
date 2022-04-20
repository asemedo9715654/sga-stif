using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Socio;

namespace sga_stif.Controllers
{
  public class SocioController : Controller
  {


    private readonly ContextoBaseDados _context;
    private readonly INotyfService _notyf;
    private readonly IMapper _mapper;

    public SocioController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
    {
      _context = context;
      _notyf = notyf;
      _mapper = mapper;
    }



    public async Task<IActionResult> ListaSocio()
    {
      var socios = await _context.Socio.Where(r => r.Eliminado != true).Include(c => c.Agencia)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.TipoQuota)
                                  .ToListAsync();

      var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

      return View(sociocc);
    }

    public async Task<IActionResult> ListaSocioInativos()
    {
      var socios = await _context.Socio.Where(r => r.Eliminado == true).Include(c => c.Agencia)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.TipoQuota)
                                  .ToListAsync();

      var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

      return View(sociocc);
    }

    [HttpGet]
    public IActionResult NovoSocio()
    {
      var angencia = _context.Agencia.Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.ToList();
      var tipoQuotas = _context.TipoQuota.ToList();

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Cidade.Nome + " - " + g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };

      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> NovoSocio([Bind("Nome,NumeroDeTelemovel,NumeroDeTelefone,DataDeNascimento,Sexo,Apelido,CinBi,Foto,NumeroPassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif,DataAtivacao ")] NovoSocioViewModel novoSocioViewModel, IFormFile Image)
    {
      try
      {
        if (ModelState.IsValid)
        {

          if (Image != null)
          {
            if (Image.Length > 0)

            //Convert Image to byte and save to database

            {

              byte[] p1 = null;
              using (var fs1 = Image.OpenReadStream())
              using (var ms1 = new MemoryStream())
              {
                fs1.CopyTo(ms1);
                p1 = ms1.ToArray();
              }
              novoSocioViewModel.Foto = p1;

            }
          }

          var socio = _mapper.Map<Socio>(novoSocioViewModel);
          socio.NumeroColaborador = "0";

          _notyf.Success("Sócio adicionado com sucesso!");

          socio.GerarNumeroSocio();

          _context.Socio.Add(socio);
          await _context.SaveChangesAsync();
          return RedirectToAction("ListaSocio");
        }

      }
      catch (DbUpdateException ex)
      {
        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
        throw;
      }

      _notyf.Error("Erro na inserção de sócio!");


      var angencia = _context.Agencia.Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.ToList();
      var tipoQuotas = _context.TipoQuota.ToList();
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;


      return View(novoSocioViewModel);
    }




    [HttpGet]
    public IActionResult EditaSocio(int idSocio)
    {
      var angencia = _context.Agencia.Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.ToList();
      var tipoQuotas = _context.TipoQuota.ToList();

      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Cidade.Nome + " - " + g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };

      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

      var socio = _context.Socio.FirstOrDefault(s => s.IdSocio == idSocio);

      var editaSocioViewModel = _mapper.Map<EditaSocioViewModel>(socio);

      return View(editaSocioViewModel);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditaSocio([Bind("IdSocio,Nome,NumeroDeTelemovel,NumeroDeTelefone,DataDeNascimento,Sexo,Apelido,CinBi,ValidadeCinBi,Foto,NumeroPassaporte,ValidadePassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif ")] EditaSocioViewModel editaSocioViewModel, IFormFile Image)
    {
      try
      {
        if (ModelState.IsValid)
        {

          if (Image != null)
          {
            if (Image.Length > 0)

            //Convert Image to byte and save to database

            {

              byte[] p1 = null;
              using (var fs1 = Image.OpenReadStream())
              using (var ms1 = new MemoryStream())
              {
                fs1.CopyTo(ms1);
                p1 = ms1.ToArray();
              }
              editaSocioViewModel.Foto = p1;

            }
          }

          var socio = _mapper.Map<Socio>(editaSocioViewModel);

          _notyf.Success("Sócio editado com sucesso!");

          socio.DataAtualizacao = DateTime.Now;

          _context.Update(socio);
          await _context.SaveChangesAsync();
          return RedirectToAction("ListaSocio");
        }

      }
      catch (DbUpdateException ex)
      {
        ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
        throw;
      }

      _notyf.Error("Erro na edição de sócio!");


      var angencia = _context.Agencia.Include(j => j.Cidade).ToList();
      var tipologiaSocios = _context.TipologiaSocio.ToList();
      var tipoQuotas = _context.TipoQuota.ToList();
      var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

      var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Nome };
      var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
      var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };
      var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

      ViewBag.IdAgencia = angenciaListItem;
      ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
      ViewBag.IdTipoQuota = tipoQuotasListItem;
      ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;


      return View(editaSocioViewModel);
    }


    [HttpGet]
    public async Task<IActionResult> DetalhesSocio(int idSocio)
    {
      var socios = await _context.Socio.Where(j => j.IdSocio == idSocio)
                                  .Include(c => c.TipologiaSocio)
                                  .Include(c => c.Beneficiario)
                                  .Include(c => c.TipoQuota)
                                   .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
                                  .Include(c => c.Agencia).ThenInclude(c => c.Cidade).ThenInclude(c => c.Ilha).FirstOrDefaultAsync();


      var destalhesSocioViewModel = _mapper.Map<DestalhesSocioViewModel>(socios);

      return View(destalhesSocioViewModel);
    }


    public async Task<IActionResult> EliminaSocio(int? idSocio)
    {
      if (idSocio == null)
      {
        return NotFound();
      }
      var employee = await _context.Socio.FirstOrDefaultAsync(m => m.IdSocio == idSocio);

      return View(employee);
    }



    // POST: Employees/Delete/1
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EliminaSocio(int idSocio)
    {
      var socio = await _context.Socio.FindAsync(idSocio);
      socio.Eliminado = true;
      //_context.Socio.Remove(employee);
      //_context.Socio.Remove(employee);
      await _context.SaveChangesAsync();
      _notyf.Success("Sócio eliminado com sucesso!");


      return RedirectToAction("ListaSocio");
    }



    [HttpGet]
    public JsonResult PegarAgencia(int idInstituicaoFinanceira)
    {

      var perfilMenuAcao = _context.Agencia.Where(a => a.IdInstituicaoFinanceira == idInstituicaoFinanceira).ToList();

      var dadosAgencia = from g in perfilMenuAcao select new { g.IdAgencia, g.Nome };

      return Json(dadosAgencia);

    }


    //validacoes remoto
    [AcceptVerbs("GET", "POST")]
    public IActionResult VereficaCniBi(string cniBi)
    {
      var socio = _context.Socio.FirstOrDefault(k => k.CinBi == cniBi);
      if (socio != null)
      {
        return Json($"O CNI/BI {cniBi} já foi inserida no sistema");
      }

      return Json(true);
    }


    [AcceptVerbs("GET", "POST")]
    public IActionResult VereficaNumeroPassaporte(string numeroPassaporte)
    {
      var socio = _context.Socio.FirstOrDefault(k => k.NumeroPassaporte== numeroPassaporte);
      if (socio != null)
      {
        return Json($"O Número de Passaporte {numeroPassaporte} já foi inserida no sistema");
      }

      return Json(true);
    }



  }
}