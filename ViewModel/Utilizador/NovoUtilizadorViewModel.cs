using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace sga_stif.ViewModel.Utilizador
{
  public class NovoUtilizadorViewModel
  {
    [Key]
    public int IdUtilizador { get; set; }

     [Display(Name = "Nome", Description = "Nome do utilizador")]
    [Required(ErrorMessage = "O Nome é necessário")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Nome do utilizador necessário",AllowEmptyStrings=false)]
    [StringLength(20, ErrorMessage = "O nome do utilizador não pode ser mais de 20")]
    [Remote(action: "VereficaNomeUtilizador", controller: "Utilizador")]
      [Display(Name = "Nome do Login", Description = "Nome para inicializar sessao")]
    public string NomeUtilizador { get; set; }

    [Required(ErrorMessage = "O Apelido é necessário",AllowEmptyStrings=false)]
      [Display(Name = "Apelido", Description = "Apelido do utilizador")]
    public string Apelido { get; set; }

    [Required(ErrorMessage = "O E-mail é necessário")]

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    [Remote(action: "VereficaEmail", controller: "Utilizador")]
      [Display(Name = "E-mail", Description = "E-mail do utilizador")]
    public string Email { get; set; }

      [Display(Name = "Fotografia", Description = "Fotografia  do utilizador")]
    public byte[]? Foto { get; set; }
    [Required(ErrorMessage = "A Palavra-Passe é necessário",AllowEmptyStrings=false)]
    [StringLength(10,MinimumLength=4)]
      [Display(Name = "Palavra-Passe", Description = "Palavra Passe do utilizador")]
    public string PalavraPasse { get; set; }

    [Required(ErrorMessage = "O Perfil é necessário")]
    public int IdPerfil { get; set; }

  }

}