using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Utilizador : EntidadeBase
    {
        [Key]
        public int IdUtilizador { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Foto { get; set; }
        public string PalavraPasse { get; set; }
        public string PalavraPasseSalt { get; set; }


        public string PegarNomeCompleto(){
            return Nome +" "+ Apelido;
        }
    }
}