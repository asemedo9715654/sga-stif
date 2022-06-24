using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.Socio;
using sga_stif.ViewModel.TipoQuota;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace sga_stif.Controllers
{
    public class FicheiroController : BaseController
    {

        private readonly ContextoBaseDados _context;

        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;


        public FicheiroController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
        }


        // GET: ClonePanel
        public ActionResult CarregamentoDeFicheiro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CarregamentoDeFicheiro(IFormFile? ficheiro = null)
        {
           
            return View();
        }



    }
}