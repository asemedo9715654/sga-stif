using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Serilog;
using sga_stif.Models;
using System.Text;

namespace sga_stif.Controllers
{
    public class FicheiroController : BaseController
    {

        private readonly ContextoBaseDados _context;
        private readonly INotyfService _notyf;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _appEnvironment;

        public FicheiroController(ContextoBaseDados context, INotyfService notyf, IMapper mapper, IWebHostEnvironment env)
        {
            _context = context;
            _notyf = notyf;
            _mapper = mapper;
            _appEnvironment = env;
        }


        // GET: ClonePanel
        public ActionResult CarregamentoDeFicheiro()
        {

            var instituicaoFinanceiras = _context.InstituicaoFinanceira.Where(a => a.Eliminado == false).ToList();
            var instituicaoFinanceirasItem = from g in instituicaoFinanceiras select new SelectListItem { Value = g.IdInstituicaoFinanceira.ToString(), Text = g.Nome };

            ViewBag.IdInstituicaoFinanceira = instituicaoFinanceirasItem;

            return View();
        }

        [HttpPost]
        public ActionResult ImportarFicheiro()
        {

            var sb = new StringBuilder();

            try
            {

                int contador = 0, IdInstituicaoFinanceira = 0;
                var file = Request.Form.Files[0];
                string instituicaoFinanceiraTratado = null;
                var instituicaoFinanceiraPegado = Request.Form["InstitiucaoFinanceira"];
                instituicaoFinanceiraTratado = instituicaoFinanceiraPegado.ToString();

                if (!string.IsNullOrEmpty(instituicaoFinanceiraTratado))
                {
                    IdInstituicaoFinanceira = int.Parse(instituicaoFinanceiraTratado);
                }
                else
                {
                    sb.Append($"<div class=\"card-body\"> <div class=\"alert alert-danger alert-dismissible\"> <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h5><i class=\"icon fas fa-check\"></i> Erro!</h5> Instituicao financeira invalida !!! </div> </div>");

                    return this.Content(sb.ToString());
                }

                var folderName = "UploadExcel";
                var webRootPath = _appEnvironment.WebRootPath;
                var newPath = Path.Combine(webRootPath, folderName);

                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                if (file.Length > 0)
                {
                    var sFileExtension = Path.GetExtension(file.FileName).ToLower();
                    ISheet folha;
                    var fullPath = Path.Combine(newPath, file.FileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        stream.Position = 0;
                        if (sFileExtension == ".xls")
                        {
                            var hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                            folha = hssfwb.GetSheetAt(0); //get first sheet from workbook  
                        }
                        else
                        {
                            var hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                            folha = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                        }

                        for (var i = (folha.FirstRowNum + 1); i <= folha.LastRowNum; i++) //Read Excel File
                        {
                            var linha = folha.GetRow(i);
                            if (linha == null) continue;


                            var numeroColaborador = "";
                            var mes = 0;
                            var ano = 0;
                            decimal montante = 0;

                            var collllll = linha.Cells.All(d => d.CellType != CellType.Blank);

                            if (linha.GetCell(0) != null && linha.GetCell(1) != null && linha.GetCell(2) != null && linha.GetCell(3) != null && linha.GetCell(4) != null)
                            {
                                numeroColaborador = linha.GetCell(0).ToString();

                                decimal.TryParse(linha.GetCell(2).ToString(), out montante);
                                int.TryParse(linha.GetCell(3).ToString(), out mes);
                                int.TryParse(linha.GetCell(4).ToString(), out ano);


                                if (numeroColaborador != "" && mes != 0 && ano != 0)
                                {

                                    var quotaSocio = _context.QuotaSocio
                                    .Where(h => h.Socio.NumeroColaborador == numeroColaborador && h.PeriodoQuota.Mes == mes && h.PeriodoQuota.Ano == ano && h.Socio.Agencia.IdInstituicaoFinanceira == IdInstituicaoFinanceira)
                                    .Include(d => d.Socio).ThenInclude(d => d.Agencia).ThenInclude(d => d.InstituicaoFinanceira)
                                    .Include(d => d.PeriodoQuota)
                                    .FirstOrDefault();

                                    if (quotaSocio != null)
                                    {
                                        contador++;
                                        quotaSocio.OrigemPagamento = "Ficheiro";
                                        quotaSocio.Estado = EstadoQuotaSocio.Pago;
                                        quotaSocio.Montante = montante;

                                        quotaSocio.DataQueFoiEfectuadaPagamento = DateTime.Now;
                                        quotaSocio.UtilizadorQueEfectuouPagamento = PegarNomeUtilizador();
                                        quotaSocio.DataAtualizacao = DateTime.Now;

                                        _context.Update(quotaSocio);
                                        _context.SaveChanges();
                                    }

                                }

                            }
                        }
                    }
                }

                sb.Append($"<div class=\"card-body\"> <div class=\"alert alert-success alert-dismissible\"> <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h5><i class=\"icon fas fa-check\"></i> Sucesso!</h5> Foram efectuado {contador} pagamentos com sucesso !!! </div> </div>");

                return this.Content(sb.ToString());

            }
            catch (System.Exception e)
            {

                Log.Error(e.Message);

                sb.Append($"<div class=\"card-body\"> <div class=\"alert alert-danger alert-dismissible\"> <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h5><i class=\"icon fas fa-check\"></i> Erro!</h5> Erro :  {e.Message}!!! </div> </div>");

                return this.Content(sb.ToString());
            }

        }

    }
}