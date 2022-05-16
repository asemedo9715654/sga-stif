using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Filtros;
using sga_stif.Models;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.TipoQuota;

namespace sga_stif.Controllers
{
    [BreadcrumbActionFilter]
    public class BaseController : Controller
    {




        public string PegarNomeUtilizador()
        {
            return HttpContext.Session.GetString("NomeUtilizador"); ;
        }


    }
}