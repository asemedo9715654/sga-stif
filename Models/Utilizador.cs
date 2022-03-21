using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class Utilizador : EntidadeBase
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
        public string PalavraPasse { get; set; }

        [ForeignKey("Perfil")]
        public int? IdPerfil { get; set; }
        public virtual  Perfil? Perfil { get; set; }


        public string PegarNomeCompleto(){
            return Nome +" "+ Apelido;
        }
    }
}