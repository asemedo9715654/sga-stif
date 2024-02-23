using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Beneficiario;

namespace sga_stif.Controllers
{
    public class BeneficiarioController : BaseController
    {

        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;

        public BeneficiarioController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
        {
            _notyf = notyf;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult NovoBeneficiario(int idSocio)
        {
            var novoBeneficiarioViewModel = new NovoBeneficiarioViewModel
            {
                IdSocio = idSocio
            };


            return View(novoBeneficiarioViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoBeneficiario([Bind("Nome,Apelido,DataDeNascimento,GrauDeParentesco,Nif,IdSocio, CinBi,NumeroPassaporte")] NovoBeneficiarioViewModel novoBeneficiarioViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var beneficiario = _mapper.Map<Beneficiario>(novoBeneficiarioViewModel);
                    _context.Beneficiario.Add(beneficiario);
                    _context.SaveChanges();
                    _notyf.Success("Beneficiario adicionado com sucesso!");
                    return RedirectToAction("DetalhesSocio", "Socio", new { idSocio = beneficiario.IdSocio });
                }

            }
            catch (DbUpdateException e)
            {
                ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists " + "see your system administrator."+e.Message);
            }

            _notyf.Error("Erro na adição de Beneficiário!");
            return View(novoBeneficiarioViewModel);
        }



        [HttpGet]
        public IActionResult EditaBeneficiario(int idSocio, int idBeneficiario)
        {
            var beneficiario = _context.Beneficiario.FirstOrDefault(j => j.IdSocio == idSocio && j.IdBeneficiario == idBeneficiario);
            var editaBeneficiarioViewModel = _mapper.Map<EditaBeneficiarioViewModel>(beneficiario);
            return View(editaBeneficiarioViewModel);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditaBeneficiario([Bind("IdBeneficiario,Nome,Apelido,DataDeNascimento,GrauDeParentesco,Nif,IdSocio, CinBi,NumeroPassaporte")] EditaBeneficiarioViewModel editaBeneficiarioViewModel)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    var beneficiario = _mapper.Map<Beneficiario>(editaBeneficiarioViewModel);
                    beneficiario.DataAtualizacao = DateTime.Now;
                    _context.Beneficiario.Update(beneficiario);
                    _context.SaveChanges();
                    _notyf.Success("Beneficiário atualizado com sucesso!");
                    return RedirectToAction("DetalhesSocio", "Socio", new { idSocio = beneficiario.IdSocio });
                }
            }
            catch (DbUpdateException e)
            {
                ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists " + "see your system administrator."+e.Message);
            }

            _notyf.Error("Erro na atualização de Beneficiário!");

            return View(editaBeneficiarioViewModel);
        }


        //validacoes   //validacoes remoto
        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaCniBi(string CinBi)
        {
            var socio = _context.Beneficiario.FirstOrDefault(k => k.CinBi == CinBi);
            if (socio != null)
            {
                return Json($"O CNI/BI {CinBi} já foi inserida no sistema");
            }

            return Json(true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNif(string Nif)
        {
            var socio = _context.Beneficiario.FirstOrDefault(k => k.Nif == Nif);
            if (socio != null)
                return Json($"O NIF {Nif} já foi inserida no sistema");

            return Json(true);
        }


        [AcceptVerbs("GET", "POST")]
        public IActionResult VereficaNumeroPassaporte(string NumeroPassaporte)
        {
            var socio = _context.Beneficiario.FirstOrDefault(k => k.NumeroPassaporte == NumeroPassaporte);
            if (socio != null)
                return Json($"O Numero de passaporte : {NumeroPassaporte} já foi inserida no sistema");

            return Json(true);
        }



    }
}