using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sga_stif.Models;
using sga_stif.ViewModel.Socio;

namespace sga_stif.Controllers
{
    public class SocioController : Controller
    {


        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;

        public SocioController(ContextoBaseDados context, INotyfService notyf, IMapper mapper)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
        }



        public async Task<IActionResult> Index()
        {
            var socios = await _context.Socio.Include(c => c.Agencia)
                                        .Include(c => c.TipologiaSocio)
                                        .Include(c => c.TipoQuota)
                                        .ToListAsync();
            return View(socios);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var angencia = _context.Agencia.ToList();
            var tipologiaSocios = _context.TipologiaSocio.ToList();
            var tipoQuotas = _context.TipoQuota.ToList();

            var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Nome };
            var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
            var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };

            ViewBag.IdAgencia = angenciaListItem;
            ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
            ViewBag.IdTipoQuota = tipoQuotasListItem;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome,Apelido,CinBi,Foto,NumeroPassaporte,IdTipologiaSocio ,IdTipoQuota,IdAgencia,Nif ")] SocioViewModel socioViewModel, IFormFile Image)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (Image != null)
                    {
                        if (Image.Length > 0)

                        //Convert Image to byte and save to database

                        {

                            byte[] p1 = null;
                            using (var fs1 = Image.OpenReadStream())
                            using (var ms1 = new MemoryStream())
                            {
                                fs1.CopyTo(ms1);
                                p1 = ms1.ToArray();
                            }
                            socioViewModel.Foto = p1;

                        }
                    }

                    var sociocc = _mapper.Map<Socio>(socioViewModel);

                    _notyf.Success("Sócio adicionado com sucesso!");

                    _context.Socio.Add(sociocc);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var ee = 2;

            }
            catch (DbUpdateException ex)
            {

                throw;
            }

            _notyf.Error("Erro na inserção de sócio!");


            var angencia = _context.Agencia.ToList();
            var tipologiaSocios = _context.TipologiaSocio.ToList();
            var tipoQuotas = _context.TipoQuota.ToList();

            var angenciaListItem = from g in angencia select new SelectListItem { Value = g.IdAgencia.ToString(), Text = g.Nome };
            var tipologiaSociosListItem = from g in tipologiaSocios select new SelectListItem { Value = g.IdTipologiaSocio.ToString(), Text = g.Descricao };
            var tipoQuotasListItem = from g in tipoQuotas select new SelectListItem { Value = g.IdTipoQuota.ToString(), Text = g.Descricao };

            ViewBag.IdAgencia = angenciaListItem;
            ViewBag.IdTipologiaSocio = tipologiaSociosListItem;
            ViewBag.IdTipoQuota = tipoQuotasListItem;


            return View(socioViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Detalhes(int idSocio)
        {
            var socios = await _context.Socio.Where(j => j.IdSocio == idSocio).Include(c => c.TipologiaSocio)
                                        .Include(c => c.TipoQuota)
                                        .Include(c => c.Agencia).FirstOrDefaultAsync();


            var sociocc = _mapper.Map<DestalhesSocioViewModel>(socios);
            //  sociocc.ListaBeneficiarioViewModel = _mapper.Map<DestalhesSocioViewModel>(socios);

            return View(sociocc);
        }

    }
}