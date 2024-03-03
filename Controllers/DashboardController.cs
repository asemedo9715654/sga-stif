using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using SmartBreadcrumbs.Attributes;

namespace sga_stif.Controllers
{
    [DefaultBreadcrumb]
    public class DashboardController : BaseController
    {

        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;

        public DashboardController(ContextoBaseDados context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }

        public IActionResult Inicio()
        {


			var today = DateTime.Today;

			var socios = _context.Socio.AsNoTracking().ToList();
            ViewBag.TotalSocios = socios.Count(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));
            ViewBag.SocioInativos = socios.Where(g => g.Eliminado == true && ListaAgenciasPermitidas(_context).Contains(g.IdAgencia)).Count();
            ViewBag.SocioAtivos = socios.Where(g => g.Eliminado == false).Count(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));
            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(e => ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).ToList();
            ViewBag.TotalInstituicaoFinanceiras = instituicaoFinanceiras.Count();
            var agencia = _context.Agencia.ToList();
            ViewBag.TotalAgencia = agencia.Count(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));
			//new line
			ViewBag.TotalSociosRegistradoHoje = socios.Count(e => e.DataCriacao.Value.Date ==   today && ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));
			ViewBag.TotalPagamentoHoje = _context.QuotaSocio.Count(e => e.DataCriacao.Value.Date ==   today );
			ViewBag.TotalTipologiaSocio = _context.TipologiaSocio.Count(e => e.Eliminado ==   false );
			ViewBag.TotalTipoQuota = _context.TipoQuota.Count(e => e.Eliminado ==   false );


			return View();
        }
    }
}