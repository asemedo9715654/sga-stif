using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
  public class NovoUtilizadorViewModel
  {
    [Key]
    public int IdUtilizador { get; set; }
    [Required(ErrorMessage = "O Nome é necessário")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Nome do utilizador necessário")]
    public string NomeUtilizador { get; set; }

    [Required(ErrorMessage = "O Apelido é necessário")]
    public string Apelido { get; set; }

    [Required(ErrorMessage = "O E-mail é necessário")]

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
    public byte[]? Foto { get; set; }
    [Required(ErrorMessage = "A Palavra-Passe é necessário")]
    public string PalavraPasse { get; set; }

    [Required(ErrorMessage = "O Perfil é necessário")]
    public int IdPerfil { get; set; }

  }

}