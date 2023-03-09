using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;

namespace sga_stif.ViewComponents
{
    public class VereficaCheckMenuAcaoViewComponent : ViewComponent
    {

        private readonly ContextoBaseDados _context;

        public VereficaCheckMenuAcaoViewComponent(ContextoBaseDados context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int idAcao, int idMenu)
        {
            var menuAcao = await _context.MenuAcao.FirstOrDefaultAsync(a => a.IdMenu == idMenu && a.IdAcao == idAcao);
            sga_stif.ViewModel.MenuAcao.DadosComponente dadosComponente = new sga_stif.ViewModel.MenuAcao.DadosComponente(){IdMenuAcao=idMenu, IdMenu = idMenu,IdAcao=idAcao,Preenchido = menuAcao != null ? true : false};
            return View(dadosComponente);
        }

    }
}