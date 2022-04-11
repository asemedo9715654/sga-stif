using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.Utilizador
{
  public class ListaUtilizadorViewModel : BaseViewModel
  {
    [Key]
    public int IdUtilizador { get; set; }
    public string Nome { get; set; }
    [Display(Name = "Nome do Utilizador")]
    public string NomeUtilizador { get; set; }
    public string Apelido { get; set; }

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    [Display(Name = "E-mail")]
    public string Email { get; set; }
    public string Foto { get; set; }
    public string PalavraPasse { get; set; }
    [Display(Name = "Nome do Perfil")]
    public string NomePerfil { get; set; }

   

  }

}