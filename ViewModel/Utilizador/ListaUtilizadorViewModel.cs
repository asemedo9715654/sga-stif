using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
  public class ListaUtilizadorViewModel
  {
    [Key]
    public int IdUtilizador { get; set; }
    public string Nome { get; set; }
     [Display(Name ="Nome do Utilizador")]
    public string NomeUtilizador { get; set; }
    public string Apelido { get; set; }

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
     [Display(Name ="E-mail")]
    public string Email { get; set; }
    public byte[]? Foto { get; set; }
    public string PalavraPasse { get; set; }
     [Display(Name ="Nome do Perfil")]
    public string NomePerfil { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
     [Display(Name ="Data de Criação")]
    public DateTime? DataCriacao { get; set; } 

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name ="Data de Atualização")]
    public DateTime? DataAtualizacao { get; set; }

  }

}