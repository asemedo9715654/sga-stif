using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;

namespace sga_stif.ViewComponents
{
    public class BotaoComponent : ViewComponent
    {
        private readonly ContextoBaseDados _context;

        public BotaoComponent(ContextoBaseDados context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync(int idPerfil, int idMenuAcao)
        {
            // var perfilMenuAcao = await _context.PerfilMenuAcao.FirstOrDefaultAsync(a => a.IdPPerfil == idPerfil && a.IdMenuAcao == idMenuAcao);

            // DadosComponente v = new DadosComponente(){ IdMenuAcao = idMenuAcao,IdPerfil=idPerfil,Preenchido = perfilMenuAcao != null ? true : false};
            return View(1);
        }
        
    }
}