using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
  public class PosicaoIFsResultado
  {
    [Display(Name ="Instituição Financeira")]
    public string IFNome { get; set; }
    public int IdInstituicaoFinanceira { get; set; }
    [Display(Name = "Total de Sócio Anterior")]
    public int TotalSocioAnterior { get; set; }
    [Display(Name = "Total de Sócio Atual")]
    public int TotalSocioAtual { get; set; }
    [Display(Name = "Total de Colaboradores Anterior")]
    public int TotalColaboradoresAnterior { get; set; }
    [Display(Name = "Total de Colaboradores Atual")]
    public int TotalColaboradoresAtual { get; set; }
    [DisplayFormat(DataFormatString ="{0:N}")]
    [Display(Name = "Total Quotas Mês Anterior")]
    public double TotalQuoataMesAnterior { get; set; }

    [Display(Name = "Total Quotas Mês Atual")]
     [DisplayFormat(DataFormatString ="{0:N}")]
    public double TotalQuoataMesAtual { get; set; }
    public int Estado { get; set; }
    public int Variacao { get; set; }


  }


}