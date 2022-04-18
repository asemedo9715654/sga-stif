using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
  public class NovoPerfilViewModel
  {
    [Required(ErrorMessage = "O Nome é necessãrio")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descriçāo é necessãrio")]
    public string Descricao { get; set; }


  }
}