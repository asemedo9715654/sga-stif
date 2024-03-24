using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using sga_stif.Models;
using sga_stif.ViewModel.Utilizador;

namespace sga_stif.Controllers
{
    public class ComunController : Controller
    {
        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;
        private readonly ILogger<UtilizadorController> _logger;

        public ComunController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, ILogger<UtilizadorController> logger)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public JsonResult GerarAcaoMaster()
        {
            var menus = _context.Menu.ToList();
            foreach (var item in menus)
            {
                var acao = new Acao(item);
                _context.Acao.Add(acao);
                _context.SaveChanges();

                var menuAcao = new MenuAcao(acao, item);
                _context.MenuAcao.Add(menuAcao);
                _context.SaveChanges();
            }

            return Json(2);
        }
    }
}