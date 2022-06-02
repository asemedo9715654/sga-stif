using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
  public class RakingSocioResultado
  {
    [Display(Name ="Nome do Sócio")]

    public string Nome { get; set; }
     [Display(Name ="Número do Sócio")]
    public string NumeroDeSocio { get; set; }
    public int IdSocio { get; set; }
     [Display(Name ="Instituição Financeira")]
    public string IFS { get; set; }
     [Display(Name ="Agência")]
    public string AgenciaNome { get; set; }
     [Display(Name ="Meses Pago")]
    public string MesesPago { get; set; }
     [Display(Name ="Total Pago")]
    public string TotalMontantePago { get; set; }
    

  }


}