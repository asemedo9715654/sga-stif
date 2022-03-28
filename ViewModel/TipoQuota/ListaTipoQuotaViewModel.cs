using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.TipoQuota
{
  public class ListaTipoQuotaViewModel
  {
    [Key]
    public int IdTipoQuota { get; set; }
     [Display(Name ="Descrição")]
    public string Descricao { get; set; }
     [Display(Name ="Prioridicidade De Quota")]
    public int Priodicidade { get; set; }
     [Display(Name ="Montante a ser pago")]
    public decimal Montante { get; set; }
    [Display(Name ="Tipo De Quota")]
    public TipoTipoQuota Tipo { get; set; }

  }
}