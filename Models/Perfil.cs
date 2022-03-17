using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Perfil : EntidadeBase
    {
        [Key]
        public int IdPerfil { get; set; }
        public string Descricao { get; set; }
         public List<Utilizador> Utilizador { get; set; }
    }
}