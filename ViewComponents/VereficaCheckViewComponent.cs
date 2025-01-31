using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Perfil;

namespace sga_stif.ViewComponents
{
    public class VereficaCheckViewComponent : ViewComponent
    {

        private readonly ContextoBaseDados _context;

        public VereficaCheckViewComponent(ContextoBaseDados context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int idPerfil, int idMenuAcao)
        {
            var perfilMenuAcao = await _context.PerfilMenuAcao.FirstOrDefaultAsync(a => a.IdPPerfil == idPerfil && a.IdMenuAcao == idMenuAcao);
            var dadosComponente = new DadosComponente() { IdMenuAcao = idMenuAcao, IdPerfil = idPerfil, Preenchido = perfilMenuAcao != null ? true : false };
            return View(dadosComponente);
        }
    }
}