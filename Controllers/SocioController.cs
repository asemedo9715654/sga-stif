using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Extensao;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;
using sga_stif.ViewModel.DataTable;
using sga_stif.ViewModel.Socio;
using SmartBreadcrumbs.Attributes;

namespace sga_stif.Controllers
{
    //[DefaultBreadcrumb]
    public class SocioController : BaseController
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

        public async Task<IActionResult> ListaSocioServerSide()
        {
            return View();
        }

        //[Breadcrumb(FromAction = "ListaSocio", Title = "Lista de Sócio")]
        public async Task<IActionResult> ListaSocio()
        {
            var sociosdd = await _context.Socio.Where(r => r.Eliminado != true).Include(c => c.Agencia)
                                      .Include(c => c.TipologiaSocio)
                                      .Include(c => c.TipoQuota)
                                      .Include(c => c.Beneficiario)
                                      .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira).Select(
                                          k => new ListaSocioViewModel(k))
                                      .ToListAsync();

            // var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);


            //return View(sociocc);
            return View(sociosdd);
        }


        #region serverside
        [HttpPost]
        public JsonResult GetEmployeeList()
        {
            var totalRecord = 0;
            var filterRecord = 0;
            var draw = Request.Form["draw"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            var pageSize = Convert.ToInt32(Request.Form["length"].FirstOrDefault() ?? "0");
            var skip = Convert.ToInt32(Request.Form["start"].FirstOrDefault() ?? "0");
            var data = _context.Set<Socio>().AsQueryable();
            //get total count of data in table
            totalRecord = data.Count();
            // search data when search value found
            if (!string.IsNullOrEmpty(searchValue))
            {
                data = data.Where(x => x.Nome.ToLower().Contains(searchValue.ToLower()) || x.Apelido.ToLower().Contains(searchValue.ToLower()) || x.Sexo.ToString().ToLower().Contains(searchValue.ToLower()) || x.Nif.ToString().ToLower().Contains(searchValue.ToLower()));
            }
            // get total count of records after search
            filterRecord = data.Count();
            //sort data
            //if (!string.IsNullOrEmpty(sortColumn) && !string.IsNullOrEmpty(sortColumnDirection)) 
            //data = data.OrderBy(sortColumn + " " + sortColumnDirection);
            //pagination
            var empList = data.ToList().Skip(skip).Take(pageSize).ToList();
            var returnObj = new
            {
                draw = draw,
                recordsTotal = totalRecord,
                recordsFiltered = filterRecord,
                data = empList
            };

            return Json(returnObj);
        }

        #endregion
        public async Task<IActionResult> ListaSocioInativos()
        {
            var socios = await _context.Socio.Where(r => r.Eliminado == true).Include(c => c.Agencia)
                                        .Include(c => c.TipologiaSocio)
                                        .Include(c => c.TipoQuota)
                                        .Include(c => c.Beneficiario)
                                        .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
                                        .ToListAsync();

            var sociocc = _mapper.Map<List<ListaSocioViewModel>>(socios);

            return View(sociocc);
        }

        [HttpGet]
        public IActionResult NovoSocio()
        {
            var angencia = _context.Agencia.Where(r => r.Eliminado == false).Include(j => j.Cidade).ToList();
            var tipologiaSocios = _context.TipologiaSocio.Where(r => r.Eliminado == false).ToList();
            var tipoQuotas = _context.TipoQuota.Where(r => r.Eliminado == false).ToList();
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false).ToList();
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
        public async Task<IActionResult> NovoSocio([Bind("Nome,NumeroDeTelemovel,NumeroDeTelefone,Email,DataDeNascimento,Sexo,Apelido,CinBi,NumeroPassaporte,ValidadePassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif,DataAtivacao,ValidadeCinBi,EstadoCivil,NumeroDeSocio,NumeroColaborador,HabilitacaoLiteraria")] NovoSocioViewModel novoSocioViewModel, IFormFile? Image = null)
        {
            byte[] p1 = null;

            try
            {
                if (ModelState.IsValid)
                {

                    var resultadoValidacaoSocio = ValidaSocio(novoSocioViewModel);
                    if (resultadoValidacaoSocio.Item1 == true)
                    {
                        if (Image != null)
                        {
                            if (Image.Length > 0)
                            {

                                using (var fs1 = Image.OpenReadStream())
                                using (var ms1 = new MemoryStream())
                                {
                                    fs1.CopyTo(ms1);
                                    p1 = ms1.ToArray();
                                }

                            }
                        }

                        var socio = _mapper.Map<Socio>(novoSocioViewModel);
                        socio.Foto = p1;

                        _notyf.Success("Sócio adicionado com sucesso!");

                        socio.TransformacaoSocio();
                        _context.Socio.Add(socio);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("ListaSocio");
                    }

                    _notyf.Success(resultadoValidacaoSocio.Item2);

                }

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
                throw;
            }

            _notyf.Error("Erro na inserção de sócio!");


            var angencia = _context.Agencia.Where(r => r.Eliminado == false).Include(j => j.Cidade).ToList();
            var tipologiaSocios = _context.TipologiaSocio.Where(r => r.Eliminado == false).ToList();
            var tipoQuotas = _context.TipoQuota.Where(r => r.Eliminado == false).ToList();
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(r => r.Eliminado == false).ToList();
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
        public IActionResult EditaSocio(int idSocio, int idAgencia)
        {

            var agenciaAtul = _context.Agencia.Where(y => y.IdAgencia == idAgencia).Include(j => j.InstituicaoFinanceira).FirstOrDefault();
            var angencia = _context.Agencia.Where(j => j.IdInstituicaoFinanceira == agenciaAtul.IdInstituicaoFinanceira).Include(j => j.Cidade).ToList();
            var tipologiaSocios = _context.TipologiaSocio.Where(r => r.Eliminado == false).ToList();
            var tipoQuotas = _context.TipoQuota.Where(r => r.Eliminado == false).ToList();
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();

            var angenciaListItem = from g in angencia select new SelectListItem(g.Cidade.Nome + " - " + g.Nome, g.IdAgencia.ToString(), agenciaAtul.IdAgencia == g.IdAgencia);
            var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem(g.Descricao, g.IdTipologiaSocio.ToString());
            var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem(g.Descricao, g.IdTipoQuota.ToString());
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem(g.Nome, g.IdInstituicaoFinanceira.ToString(), g.IdInstituicaoFinanceira == agenciaAtul.IdInstituicaoFinanceira);

            ViewBag.IdAgencia = angenciaListItem;
            ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
            ViewBag.IdTipoQuota = tipoQuotasListItem;
            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            var socio = _context.Socio.FirstOrDefault(s => s.IdSocio == idSocio);

            var editaSocioViewModel = _mapper.Map<EditaSocioViewModel>(socio);

            editaSocioViewModel.IdInstituicaoFinanceira = agenciaAtul.IdInstituicaoFinanceira;

            return View(editaSocioViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditaSocio([Bind("IdSocio,Nome,NumeroDeTelemovel,NumeroDeTelefone,Email,DataDeNascimento,Sexo,Apelido,CinBi,NumeroPassaporte,ValidadePassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif,DataAtivacao,ValidadeCinBi,EstadoCivil,NumeroDeSocio,NumeroColaborador,HabilitacaoLiteraria,IdInstituicaoFinanceira")] EditaSocioViewModel editaSocioViewModel/*, IFormFile Image*/)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var socio = _mapper.Map<Socio>(editaSocioViewModel);
                    socio.Foto = null;
                    _notyf.Success("Sócio editado com sucesso!");
                    socio.DataAtualizacao = DateTime.Now;
                    _context.Update(socio);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListaSocio");
                }


                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var ee = 2;

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
                throw;
            }

            _notyf.Error("Erro na edição de Sócio!");


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


            destalhesSocioViewModel.ListaContaCorrenteSocioResultado_Pagas = PegarContaCorrenteSocioResultado(DateTime.Now.Year, idSocio, "QP");
            destalhesSocioViewModel.ListaContaCorrenteSocioResultado_PorPagar = PegarContaCorrenteSocioResultado(DateTime.Now.Year, idSocio, "QD");
            destalhesSocioViewModel.ListaContaCorrenteSocioResultado_Vencidas = PegarContaCorrenteSocioResultado(DateTime.Now.Year, idSocio, "QV");
            destalhesSocioViewModel.ListaContaHistorialSocioResultadoHistorial = PegarContaHistorialSocioResultado(DateTime.Now.Year, idSocio);

            return View(destalhesSocioViewModel);
        }

        private List<ContaCorrenteSocioResultado> PegarContaCorrenteSocioResultado(int ano, int idSocio, string status)
        {

            var query = "EXECUTE  [dbo].[ContaCorrenteSocio] @ano = " + ano + ", @idSocio=" + idSocio + ",@user =" + PegarNomeUtilizador() + ", @status='" + status + "'";

            var listaContaCorrenteSocioResultado = _context.ContaCorrenteSocioResultado.FromSqlRaw(query).ToList();

            return listaContaCorrenteSocioResultado;

        }


        private List<ContaHistorialSocioResultado> PegarContaHistorialSocioResultado(int ano, int idSocio)
        {

            var listaContaHistorialSocioResultado = _context.ContaHistorialSocioResultado.FromSqlRaw($"[dbo].[ContaHistorialSocio] @ano = {ano}, @idSocio = {idSocio}, @status = N'QH'").ToList();

            return listaContaHistorialSocioResultado;

        }

        public async Task<IActionResult> InativarSocio(int? idSocio)
        {
            if (idSocio == null)
            {
                return NotFound();
            }
            var socio = await _context.Socio.FirstOrDefaultAsync(m => m.IdSocio == idSocio);


            var socios = await _context.Socio.Where(j => j.IdSocio == idSocio)
                                        .Include(c => c.TipologiaSocio)
                                        .Include(c => c.Beneficiario)
                                        .Include(c => c.TipoQuota)
                                        .Include(c => c.Agencia).ThenInclude(c => c.InstituicaoFinanceira)
                                        .Include(c => c.Agencia).ThenInclude(c => c.Cidade).ThenInclude(c => c.Ilha).FirstOrDefaultAsync();


            var destalhesSocioViewModel = _mapper.Map<DestalhesSocioViewModel>(socios);

            return View(destalhesSocioViewModel);
        }

        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InativarSocio(int idSocio)
        {
            var socio = await _context.Socio.FindAsync(idSocio);
            socio.Eliminado = true;
            await _context.SaveChangesAsync();
            _notyf.Success("Sócio Inativado com sucesso!");


            return RedirectToAction("ListaSocio");
        }



        public async Task<IActionResult> ReativarSocio(int idSocio)
        {
            var perfil = await _context.Socio.FindAsync(idSocio);
            perfil.Eliminado = false;
            perfil.DataAtualizacao = DateTime.Now;

            await _context.SaveChangesAsync();
            _notyf.Success("Sócio reativado com sucesso!");


            return RedirectToAction("ListaSocio");
        }


        [HttpGet]
        public JsonResult PegarAgencia(int idInstituicaoFinanceira)
        {

            var perfilMenuAcao = _context.Agencia.Where(a => a.IdInstituicaoFinanceira == idInstituicaoFinanceira && a.Eliminado == false).ToList();

            var dadosAgencia = from g in perfilMenuAcao select new { g.IdAgencia, g.Nome };

            return Json(dadosAgencia);

        }


        #region validações



        public Tuple<bool, string> ValidaSocio(NovoSocioViewModel novoSocioViewModel)
        {
            var instituicaoFinanceira = _context.Agencia.Include(J => J.InstituicaoFinanceira).FirstOrDefault(k => k.IdAgencia == novoSocioViewModel.IdAgencia);

            if (instituicaoFinanceira == null)
            {
                return Tuple.Create(false, "Agência Inexistente");

            }

            var exiteSocioComMesmoNumerColaborador = _context.Socio.Include(a => a.Agencia).ThenInclude(i => i.InstituicaoFinanceira).FirstOrDefault(j => j.NumeroColaborador == novoSocioViewModel.NumeroColaborador && j.Agencia.InstituicaoFinanceira.IdInstituicaoFinanceira == instituicaoFinanceira.IdInstituicaoFinanceira);
            if (exiteSocioComMesmoNumerColaborador != null)
            {
                return Tuple.Create(false, $"Existe colaborador com o mesmo nº de colaborador para instituição: {instituicaoFinanceira.Nome}");
            }
            return Tuple.Create(true, "Valido");
        }



        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaCniBi(string CinBi)
        {
            var socio = _context.Socio.FirstOrDefault(k => k.CinBi == CinBi);
            if (socio != null)
            {
                return Json($"O CNI/BI {CinBi} já foi inserida no sistema!");
            }

            return Json(true);
        }


        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNumeroPassaporte(string NumeroPassaporte)
        {
            var socio = _context.Socio.FirstOrDefault(k => k.NumeroPassaporte == NumeroPassaporte);
            if (socio != null)
            {
                return Json($"O Número de Passaporte {NumeroPassaporte} já foi inserida no sistema!");
            }

            return Json(true);
        }


        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNumeroDeSocio(string NumeroDeSocio)
        {
            var socio = _context.Socio.FirstOrDefault(k => k.NumeroDeSocio == NumeroDeSocio);
            if (socio != null)
            {
                return Json($"O Número de sócio {NumeroDeSocio} já foi inserida no sistema!");
            }

            return Json(true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaEmail(string Email)
        {
            var socio = _context.Socio.FirstOrDefault(k => k.Email == Email);
            if (socio != null)
            {
                return Json($"O E-mail : {Email} já foi inserida no sistema!");
            }

            return Json(true);
        }

        #endregion
        public async Task<IActionResult> RakingSocio()
        {
            var rakingSocioResultados = _context.RakingSocioResultado.FromSqlRaw($"EXECUTE  [dbo].[RakingSocio]").ToList();
            return View(rakingSocioResultados);
        }


    }
}