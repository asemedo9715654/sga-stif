using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using NPOI.SS.Formula.Functions;
using sga_stif.Models;
using sga_stif.ViewModel.Utilizador;
using BC = BCrypt.Net.BCrypt;

namespace sga_stif.Controllers
{
    public class UtilizadorController : BaseController
    {

        private readonly ContextoBaseDados _context;

        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;

        //private readonly ILogger<UtilizadorController> _logger;  
        private readonly ILogger _logger;

        public UtilizadorController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, ILogger<UtilizadorController> logger)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _logger = logger;
        }


        public async Task<IActionResult> ListaUtilizador()
        {
            var utilizadores = await _context.Utilizador.Where(t => t.Eliminado == false).Include(c => c.Perfil).ToListAsync();
            var listaUtilizadorViewModels = _mapper.Map<List<ListaUtilizadorViewModel>>(utilizadores);

            _logger.LogError("UtilizadorController.ListaUtilizadormetodo foi chamado!!!");

            return View(listaUtilizadorViewModels);
        }
        public async Task<IActionResult> ListaUtilizadorInativos()
        {
            var utilizadores = await _context.Utilizador.Where(t => t.Eliminado == true).Include(c => c.Perfil).ToListAsync();
            var listaUtilizadorViewModels = _mapper.Map<List<ListaUtilizadorViewModel>>(utilizadores);
            return View(listaUtilizadorViewModels);
        }

        [HttpGet]
        public IActionResult NovoUtilizador()
        {
            var perfils = _context.Perfil.Where(a => a.Eliminado == false).ToList();
            var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Nome };
            ViewBag.IdPerfil = perfilr;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NovoUtilizador([Bind("Nome,Apelido,PalavraPasse,PalavraPasseSalt,Email,IdPerfil,NomeUtilizador")] NovoUtilizadorViewModel novoUtilizadorViewModel, IFormFile? Image = null)
        {
            byte[] fotoEmByte = null;
            try
            {
                if (ModelState.IsValid)
                {
                    if (Image != null)
                    {
                        if (Image.Length > 0)
                        {
                            using (var fs1 = Image.OpenReadStream())
                            using (var ms1 = new MemoryStream())
                            {
                                fs1.CopyTo(ms1);
                                fotoEmByte = ms1.ToArray();
                            }
                        }
                    }

                    _notyf.Success("Utilizador adicionado com sucesso!");
                    novoUtilizadorViewModel.PalavraPasse = BCrypt.Net.BCrypt.HashPassword(novoUtilizadorViewModel.PalavraPasse);

                    var utilizador = _mapper.Map<Utilizador>(novoUtilizadorViewModel);
                    utilizador.Foto = fotoEmByte;

                    _context.Utilizador.Add(utilizador);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ListaUtilizador");
                }

                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);

            }

            _notyf.Error("Erro na inserção de utilizador!");
            var perfils = _context.Perfil.Where(j => j.Eliminado == false).ToList();
            var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Nome };
            ViewBag.IdPerfil = perfilr;
            return View(novoUtilizadorViewModel);
        }


        public async Task<IActionResult> EliminaUtilizador(int? idUtilizador)
        {
            if (idUtilizador == null)
            {
                return NotFound();
            }
            var utilizador = await _context.Utilizador.FirstOrDefaultAsync(m => m.IdUtilizador == idUtilizador);

            var inativarUtilizadorViewModel = _mapper.Map<InativarUtilizadorViewModel>(utilizador);
            return View(inativarUtilizadorViewModel);
        }



        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminaUtilizador(int idUtilizador)
        {
            var utilizador = await _context.Utilizador.FindAsync(idUtilizador);
            utilizador.Eliminado = true;

            await _context.SaveChangesAsync();
            _notyf.Success("Utilizador eliminado com sucesso!");
            return RedirectToAction("ListaUtilizador");
        }


        public async Task<IActionResult> DetalhesUtilizador(int? idUtilizador)
        {
            if (idUtilizador == null)
                return NotFound();
            var utilizador = await _context.Utilizador.Include(o => o.Perfil).FirstOrDefaultAsync(m => m.IdUtilizador == idUtilizador);
            var detalhesUtilizadorViewModel = _mapper.Map<DetalhesUtilizadorViewModel>(utilizador);

            return View(detalhesUtilizadorViewModel);
        }


        [HttpGet]
        public IActionResult EditaUtilizador(int idUtilizador)
        {
            var perfils = _context.Perfil.Where(k => k.Eliminado == false).ToList();
            var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Nome };
            ViewBag.IdPerfil = perfilr;
            var utilizador = _context.Utilizador.FirstOrDefault(g => g.IdUtilizador == idUtilizador);
            var listaPerfilViewModels = _mapper.Map<EditaUtilizadorViewModel>(utilizador);

            return View(listaPerfilViewModels);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditaUtilizador([Bind("IdUtilizador,Nome,Apelido,Email,IdPerfil,NomeUtilizador,PalavraPasse")] EditaUtilizadorViewModel editaUtilizadorViewModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    var utilizador = _mapper.Map<Utilizador>(editaUtilizadorViewModel);
                    _context.Update(utilizador);
                    await _context.SaveChangesAsync();
                    _notyf.Success("Utilizador editado com sucesso!");
                    return RedirectToAction("ListaUtilizador");
                }
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);

            }

            _notyf.Error("Erro na insercao de utilizador!");

            var perfils = _context.Perfil.Where(e => e.Eliminado == false).ToList();
            var perfilr = from g in perfils select new SelectListItem { Value = g.IdPerfil.ToString(), Text = g.Nome };
            ViewBag.IdPerfil = perfilr;

            return View(editaUtilizadorViewModel);
        }


        [HttpGet]
        public IActionResult ResetePalavraPasseUtilizador(int idUtilizador)
        {
            var resetePalavraPasseViewModel = new ResetePalavraPasseViewModel()
            {
                IdUtilizador = idUtilizador
            };

            return View(resetePalavraPasseViewModel);
        }



        [HttpGet]
        public IActionResult PerfilUtilizador()
        {
            var tt =HttpContext.Session.GetString("IdUtilizador");
            var idConvertido = int.Parse(tt);
            var utilizador = _context.Utilizador.Include(c => c.Perfil).FirstOrDefault(d => d.IdUtilizador == idConvertido);

            var dadosUtilizadorViewModel = _mapper.Map<DadosUtilizadorViewModel>(utilizador);

            return View(dadosUtilizadorViewModel);
        }
        
        [HttpGet]
        public IActionResult MudaPalavraPasse()
        {
            return View();
        }


        [HttpPost]
        public IActionResult MudaPalavraPasse(MudaPalavraPasseViewModel mudaPalavraPasseViewModel)
        {
            var tt = HttpContext.Session.GetString("IdUtilizador");
            var idConvertido = int.Parse(tt);

            var utilizador = _context.Utilizador.Include(c => c.Perfil).FirstOrDefault(d => d.IdUtilizador == idConvertido);

            try
            {
                if (ModelState.IsValid)
                {
                    if (mudaPalavraPasseViewModel.ConfirmacaoNovaPalavraPasse != mudaPalavraPasseViewModel.NovaPalavraPasse)
                    {
                        _notyf.Error("Palavra passe nao conresponde.");
                        return View(mudaPalavraPasseViewModel);
                    }

                    if (utilizador == null || !BC.Verify(mudaPalavraPasseViewModel.PalavraPasseAntiga, utilizador.PalavraPasse))
                    {
                        _notyf.Error("Erro nao vereficação da palavra passe antiga!");
                        return View(mudaPalavraPasseViewModel);
                    }



                    utilizador.PalavraPasse = BC.HashPassword(mudaPalavraPasseViewModel.NovaPalavraPasse);
                    _context.Update(utilizador);
                    _notyf.Success("Palavra passe mudada com suceso!");

                    return RedirectToAction("PerfilUtilizador");
                }
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Não foi possível salvar as alterações. Tente novamente e, se o problema persistir, consulte o administrador do sistema. Erro => " + ex.Message);

            }

            _notyf.Error("Erro na validação dos dados!!!");

            return View(mudaPalavraPasseViewModel);
        }


        [HttpPost]
        public IActionResult ResetePalavraPasseUtilizador([Bind("IdUtilizador,PalavraPasse,ConfirmacaoPalavraPasse")] ResetePalavraPasseViewModel resetePalavraPasseViewModel)
        {
            var utilizador = _context.Utilizador.FirstOrDefault(u => u.IdUtilizador == resetePalavraPasseViewModel.IdUtilizador);

            if (utilizador == null)
            {
                _notyf.Error("Utilizador não encontrado!");
                return View(resetePalavraPasseViewModel);
            }

            if (resetePalavraPasseViewModel.ConfirmacaoPalavraPasse != resetePalavraPasseViewModel.PalavraPasse)
            {
                _notyf.Error("Palavra passe não coicidem!");
                return View(resetePalavraPasseViewModel);
            }

            utilizador.PalavraPasse = BCrypt.Net.BCrypt.HashPassword(resetePalavraPasseViewModel.PalavraPasse);
            utilizador.DataAtualizacao = DateTime.Now;

            _context.Update(utilizador);

            _notyf.Success("Palavra passe resetada com sucesso!");

            return RedirectToAction("ListaUtilizador"); ;
        }

        //validacao
        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaEmail(string Email)
        {
            var utilizaddor = _context.Utilizador.FirstOrDefault(k => k.Email == Email);
            if (utilizaddor != null)
                return Json($"O E-mail : {Email} já foi inserida no sistema!");

            return Json(true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNomeUtilizador(string NomeUtilizador)
        {
            var utilizaddor = _context.Utilizador.FirstOrDefault(k => k.NomeUtilizador == NomeUtilizador);
            if (utilizaddor != null)
                return Json($"O NomeUtilizador : {NomeUtilizador} já foi inserida no sistema!");

            return Json(true);
        }


        public async Task<IActionResult> ReativarUtilizador(int idUtilizador)
        {
            var utilizador = await _context.Utilizador.FindAsync(idUtilizador);
            utilizador.Eliminado = false;
            utilizador.DataAtualizacao = DateTime.Now;

            await _context.SaveChangesAsync();
            _notyf.Success("Utilizador reativado com sucesso!");

            return RedirectToAction("ListaUtilizador");
        }


    }
}