using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
  public class NovoPerfilViewModel
  {
    [Required(ErrorMessage = "O Nome é necessário")]
     [Remote(action: "VereficaNome", controller: "Perfil")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "A Descriçāo é necessário")]
   
    public string Descricao { get; set; }


  }
}