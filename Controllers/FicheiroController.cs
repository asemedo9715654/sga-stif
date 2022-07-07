using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using sga_stif.Models;
using System.Text;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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
       

      int contador = 0,idIfff = 0;
      IFormFile file = Request.Form.Files[0];


      string idIf = Request.Query["InstitiucaoFinanceira"];
      if(!string.IsNullOrEmpty(idIf)){

        idIfff = int.Parse(idIf);

      }

      //IFormFile filed = Request.Form.TryGetValue("InstitiucaoFinanceira",out idIf);

      string folderName = "UploadExcel";
      string webRootPath = _appEnvironment.WebRootPath;
      string newPath = Path.Combine(webRootPath, folderName);
      StringBuilder sb = new StringBuilder();
      if (!Directory.Exists(newPath))
      {
        Directory.CreateDirectory(newPath);
      }
      if (file.Length > 0)
      {
        string sFileExtension = Path.GetExtension(file.FileName).ToLower();
        ISheet sheet;
        string fullPath = Path.Combine(newPath, file.FileName);
        using (var stream = new FileStream(fullPath, FileMode.Create))
        {
          file.CopyTo(stream);
          stream.Position = 0;
          if (sFileExtension == ".xls")
          {
            HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
            sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook  
          }
          else
          {
            XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
            sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
          }
          //   IRow headerRow = sheet.GetRow(0); //Get Header Row
          //   int cellCount = headerRow.LastCellNum;
          //   sb.Append("<table class='table table-bordered'><tr>");
          //   for (int j = 0; j < cellCount; j++)
          //   {
          //     NPOI.SS.UserModel.ICell cell = headerRow.GetCell(j);
          //     if (cell == null || string.IsNullOrWhiteSpace(cell.ToString())) continue;
          //     sb.Append("<th>" + cell.ToString() + "</th>");
          //   }
          //   sb.Append("</tr>");
          //   sb.AppendLine("<tr>");
          for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
          {
            IRow row = sheet.GetRow(i);
            if (row == null) continue;


            string numeroColaborador = "";
            int mes = 0;
            int ano = 0;
            decimal montante = 0;

            //se a celula nao estiver em branco
            if (row.Cells.All(d => d.CellType != CellType.Blank))
            {


              //row.GetCell(1)

              if (row.GetCell(0) != null && row.GetCell(1) != null && row.GetCell(2) != null && row.GetCell(3) != null && row.GetCell(4) != null)
              {
                numeroColaborador = row.GetCell(0).ToString();
                int.TryParse(row.GetCell(2).ToString(), out mes);
                int.TryParse(row.GetCell(3).ToString(), out ano);
                decimal.TryParse(row.GetCell(4).ToString(), out montante);

                if (numeroColaborador != "" && mes != 0 && ano != 0)
                {

                  var quotaSocio = _context.QuotaSocio
                  .Where(h => h.Socio.NumeroColaborador == numeroColaborador && h.PeriodoQuota.Mes == mes && h.PeriodoQuota.Ano == ano && h.Socio.Agencia.IdInstituicaoFinanceira == idIfff)
                  .Include(d => d.Socio).ThenInclude(d=>d.Agencia).ThenInclude(d=>d.InstituicaoFinanceira )
                  .Include(d => d.PeriodoQuota)
                  .FirstOrDefault();

                  if (quotaSocio != null)
                  {
                    contador++;
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



            // if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
            // for (int j = row.FirstCellNum; j < cellCount; j++)
            // {
            //   if (row.GetCell(j) != null)
            //     sb.Append("<td>" + row.GetCell(j).ToString() + "</td>");
            // }
            // sb.AppendLine("</tr>");
          }
          //sb.Append("</table>");
        }
      }


      sb.Append($"<div class=\"card-body\"> <div class=\"alert alert-success alert-dismissible\"> <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button> <h5><i class=\"icon fas fa-check\"></i> Alert!</h5> Foram efectuado {contador} pagamentos com sucesso !!! </div> </div>");

      return this.Content(sb.ToString());

    }



  }
}