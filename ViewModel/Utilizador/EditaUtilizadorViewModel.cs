using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
  public class EditaUtilizadorViewModel
  {
     [Key]
        public int IdUtilizador { get; set; }
        public string Nome { get; set; }
        public string NomeUtilizador { get; set; }
        public string Apelido { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public byte[]? Foto{ get; set; }
        // public string PalavraPasse { get; set; }
        public int? IdPerfil { get; set; }

  }

}