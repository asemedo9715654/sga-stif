using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
  public class EditaUtilizadorViewModel
  {
     [Key]
        public int IdUtilizador { get; set; }
         [Display(Name = "Nome", Description = "Nome do utilizador")]
        public string Nome { get; set; }
         [Display(Name = "Nome do Login", Description = "Nome para inicializar sessao")]
        public string NomeUtilizador { get; set; }
          [Display(Name = "Apelido", Description = "Apelido do utilizador")]
        public string Apelido { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
          [Display(Name = "E-mail", Description = "E-mail do utilizador")]
        public string Email { get; set; }
        public byte[]? Foto{ get; set; }
        public string PalavraPasse { get; set; }
         [Required(ErrorMessage = "O Perfil é necessário")]
        public int? IdPerfil { get; set; }

  }

}