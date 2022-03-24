using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Beneficiario
{
  public class ListaBeneficiarioViewModel
  {
    [Key]  
    public int IdBeneficiario { get; set; }
    public string Nome { get; set; }
    public string Nif { get; set; }
    public string CinBi { get; set; }
    public string NumeroPassaporte { get; set; }
  }
}