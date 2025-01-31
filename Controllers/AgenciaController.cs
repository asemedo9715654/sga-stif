using AspNetCoreHero.ToastNotification.Abstractions;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using sga_stif.Models;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.Socio;

namespace sga_stif.Controllers
{
    public class AgenciaController : BaseController
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
            var agencia = await _context.Agencia.AsSplitQuery().AsNoTracking().Where(e => e.Eliminado == false && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia))
                .Include(g => g.Cidade)
                .Include(h => h.InstituicaoFinanceira)
                .Include(h => h.Socio).ToListAsync();

            var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
            return View(listaAgenciaViewModel);
        }


        public async Task<IActionResult> ListaAgenciaInativos()
        {
            var agencia = await _context.Agencia.AsSplitQuery().AsNoTracking().Where(e => e.Eliminado == true && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia))
                .Include(g => g.Cidade)
                .Include(h => h.InstituicaoFinanceira)
                .Include(h => h.Socio).ToListAsync();

            var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
            return View(listaAgenciaViewModel);
        }


        public async Task<IActionResult> ListaAgenciaPorInstitucaoFinanceira(int idInstituicaoFinanceira, string nomeInstituicao)
        {

            ViewBag.NomeInstituicaoFinanceira = nomeInstituicao;
            var agencia = await _context.Agencia.AsSplitQuery().AsNoTracking().Where(r => r.IdInstituicaoFinanceira == idInstituicaoFinanceira && ListaAgenciasPermitidas(_context).Contains(r.IdAgencia))
                .Include(g => g.Cidade)
                .Include(h => h.InstituicaoFinanceira)
                .Include(h => h.Socio).ToListAsync();

            var listaAgenciaViewModel = _mapper.Map<List<ListaAgenciaViewModel>>(agencia);
            return View(listaAgenciaViewModel);
        }



        [HttpGet]
        public IActionResult NovaAgencia()
        {

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.AsNoTracking().Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
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
                    _notyf.Success("Agência adicionado com sucesso!");
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

                var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(h => h.Eliminado == false && ListaInstituicoesFinanceirasPermitidas(_context).Contains(h.IdInstituicaoFinanceira)).ToList();
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
        public async Task<IActionResult> EditaAgencia([Bind("IdAgencia, Nome,IdCidade,IdInstituicaoFinanceira")] EditaAgenciaViewModel editaAgenciaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var agencia = _mapper.Map<Agencia>(editaAgenciaViewModel);
                    _context.Update(agencia);
                    await _context.SaveChangesAsync();
                    _notyf.Success("Agência editado com sucesso!");
                    return RedirectToAction("ListaAgencia");
                }

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            _notyf.Error("Erro na adição de agencia");

            return View(editaAgenciaViewModel);
        }

        public async Task<IActionResult> ListaSocioPorAgencia(int idAgencia, string nomeAgencia)
        {
            ViewBag.NomeAgencia = nomeAgencia;

            var socios = await _context.Socio.AsNoTracking().AsSplitQuery().Where(r => r.Eliminado != true && r.IdAgencia == idAgencia && ListaAgenciasPermitidas(_context).Contains(r.IdAgencia))
                                        .Include(c => c.Agencia)
                                        .Include(c => c.TipologiaSocio)
                                        .Include(c => c.TipoQuota)
                                        .Include(c => c.Beneficiario)
                                        .ToListAsync();

            var listaSocioViewModel = _mapper.Map<List<ListaSocioViewModel>>(socios);

            return View(listaSocioViewModel);
        }



        public async Task<IActionResult> InativarAgencia(int? idAgencia)
        {
            if (idAgencia == null)
            {
                return NotFound();
            }
            var agencia = await _context.Agencia.Where(m => m.IdAgencia == idAgencia)
                        .Include(n => n.Cidade)
                        .Include(n => n.InstituicaoFinanceira)
                        .FirstOrDefaultAsync(m => m.IdAgencia == idAgencia);

            var inativarPerfilViewModel = _mapper.Map<InativarAgenciaViewModel>(agencia);
            return View(inativarPerfilViewModel);
        }



        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InativarAgencia(int idAgencia)
        {
            var agencia = await _context.Agencia.FindAsync(idAgencia);
            agencia.Eliminado = true;
            agencia.DataAtualizacao = DateTime.Now;

            await _context.SaveChangesAsync();
            _notyf.Success("Agência inativado com sucesso!");

            return RedirectToAction("ListaAgencia");
        }

        public async Task<IActionResult> ReativarAgencia(int idAgencia)
        {
            var agencia = await _context.Agencia.FindAsync(idAgencia);
            agencia.Eliminado = false;
            agencia.DataAtualizacao = DateTime.Now;

            await _context.SaveChangesAsync();
            _notyf.Success("Agência reativado com sucesso!");

            return RedirectToAction("ListaAgencia");
        }


    }
}