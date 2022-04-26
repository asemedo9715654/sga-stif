using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.TipologiaSocio
{
  public class ListaTipologiaSocioViewModel
  {

    public int IdTipologiaSocio { get; set; }
    public TipoTipologiaSocio Tipo { get; set; }
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }
    [Display(Name = "Total de Sócios")]
    public int TotalDeSocios { get; set; }

  }
}