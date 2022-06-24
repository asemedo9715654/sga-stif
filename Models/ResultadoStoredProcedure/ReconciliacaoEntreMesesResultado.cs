using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
  public class ReconciliacaoEntreMesesResultado
  {
    [Display(Name ="Nome")]
    public string Nome { get; set; }
    [Display(Name ="Número do Sócio")]
    public string NumeroDeSocio { get; set; }
    public int IdInstituicaoFinanceira { get; set; }
    public int IdSocio { get; set; }
    public Double? MontanteAnt { get; set; }
    public Double? MontanteAtual { get; set; } 
    public string? OBS { get; set; }
    

  }


}