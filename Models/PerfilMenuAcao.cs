using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class PerfilMenuAcao : EntidadeBase
    {
        [Key]
        public int IdPerfilMenuAcao { get; set; }
        [ForeignKey("MenuAcao")]
        public int IdMenuAcao { get; set; }
        [ForeignKey("Perfil")]
        public int IdPPerfil { get; set; }
         //propriedades de navegação
        public virtual MenuAcao MenuAcao { get; set; }
        public virtual Perfil Perfil { get; set; }

        public PerfilMenuAcao()
        {
            
        }
        public PerfilMenuAcao(int idMenuAcao, int idPerfil)
        {
            IdMenuAcao = idMenuAcao;
            IdPPerfil = idPerfil;
        }
    }
}