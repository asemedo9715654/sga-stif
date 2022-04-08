using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.TipoQuota;

namespace sga_stif.Controllers
{
    public class InstituicaoFinanceiraController : Controller
    {

        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;


        public InstituicaoFinanceiraController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
        }


        public async Task<IActionResult> ListaInstituicaoFinanceira()
        {
            var instituicaoFinanceira = await _context.InstituicaoFinanceira.Include(i=>i.Agencia).ThenInclude(k=>k.Socio).ToListAsync();
            var listaInstituicaoFinanceiraViewModel = _mapper.Map<List<ListaInstituicaoFinanceiraViewModel>>(instituicaoFinanceira);
            return View(listaInstituicaoFinanceiraViewModel);
        }



        [HttpGet]
        public IActionResult NovoInstituicaoFinanceira()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoInstituicaoFinanceira([Bind("Nome")] NovoInstituicaoFinanceiraViewModel novoInstituicaoFinanceiraViewModel)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    var instituicaoFinanceira = _mapper.Map<InstituicaoFinanceira>(novoInstituicaoFinanceiraViewModel);
                    _context.InstituicaoFinanceira.Add(instituicaoFinanceira);
                    _context.SaveChanges();
                    _notyf.Success("instituição Financeira adicionado com sucesso!");
                    return RedirectToAction("ListaInstituicaoFinanceira");
                }

            }
            catch (DbUpdateException ex)
            {

                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            _notyf.Error("Erro na adição de Instituição Financeira");

            return View(novoInstituicaoFinanceiraViewModel);
        }




        [HttpGet]
        public IActionResult EditaInstituicaoFinanceira(int idInstituicaoFinanceira)
        {

            var instituicaoFinanceira = _context.InstituicaoFinanceira.FirstOrDefault(i => i.IdInstituicaoFinanceira == idInstituicaoFinanceira);

            if (instituicaoFinanceira == null)
            {
                _notyf.Error("Instituição Financeira inexistente!");
                return RedirectToAction("ListaInstituicaoFinanceira");

            }

            var editaInstituicaoFinanceiraViewModel = _mapper.Map<EditaInstituicaoFinanceiraViewModel>(instituicaoFinanceira);

            return View(editaInstituicaoFinanceiraViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditaInstituicaoFinanceira([Bind("IdInstituicaoFinanceira,Nome")] EditaInstituicaoFinanceiraViewModel editaInstituicaoFinanceiraViewModel)
        {

            try
            {

                if (ModelState.IsValid)
                {
                    var instituicaoFinanceira = _mapper.Map<InstituicaoFinanceira>(editaInstituicaoFinanceiraViewModel);
                    _context.Update(instituicaoFinanceira);
                    _context.SaveChanges();
                    _notyf.Success("Instituição Financeira editado com sucesso!");
                    return RedirectToAction("ListaInstituicaoFinanceira");
                }

            }
            catch (DbUpdateException ex)
            {

                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);
            }

            _notyf.Error("Erro na edição de Instituição Financeira");

            return View(editaInstituicaoFinanceiraViewModel);
        }


    }
}