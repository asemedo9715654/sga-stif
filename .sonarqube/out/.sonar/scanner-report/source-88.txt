using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.Agencia
{
  public class InativarAgenciaViewModel : BaseViewModel
  {
    public int IdAgencia { get; set; }
    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O Nome da Agência é necessário!")]
    public string Nome { get; set; }
    public string NomeCidade { get; set; }
    public string NomeInstituicaoFinanceira { get; set; }


  }
}