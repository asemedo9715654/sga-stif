using AspNetCoreHero.ToastNotification.Abstractions;

using Microsoft.AspNetCore.Mvc;

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
            var socios = _context.Socio.ToList();

            ViewBag.TotalSocios = socios.Count(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));
            ViewBag.SocioInativos = socios.Where(g => g.Eliminado == true && ListaAgenciasPermitidas(_context).Contains(g.IdAgencia)).Count();
            ViewBag.SocioAtivos = socios.Where(g => g.Eliminado == false).Count(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));


            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(e => ListaInstituicoesFinanceirasPermitidas(_context).Contains(e.IdInstituicaoFinanceira)).ToList();
            ViewBag.TotalInstituicaoFinanceiras = instituicaoFinanceiras.Count();

            var agencia = _context.Agencia.ToList();
            ViewBag.TotalAgencia = agencia.Count(e => ListaAgenciasPermitidas(_context).Contains(e.IdAgencia));

            return View();
        }



    }


}