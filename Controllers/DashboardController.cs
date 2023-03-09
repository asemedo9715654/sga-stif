using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Extensao;
using sga_stif.Models;
using sga_stif.ViewModel.Estatistica;

namespace sga_stif.Controllers
{
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

            ViewBag.TotalSocios = socios.Count();
            ViewBag.SocioInativos = socios.Where(g => g.Eliminado == true).Count();
            ViewBag.SocioAtivos = socios.Where(g => g.Eliminado == false).Count();


            var instituicaoFinanceiras = _context.InstituicaoFinanceira.ToList();
            ViewBag.TotalInstituicaoFinanceiras = instituicaoFinanceiras.Count();


            var agencia = _context.Agencia.ToList();
            ViewBag.TotalAgencia = agencia.Count();

            return View();
        }



    }


}