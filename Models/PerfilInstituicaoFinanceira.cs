using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class PerfilInstituicaoFinanceira : EntidadeBase
    {
        [Key]
        public int IdPerfilInstituicaoFinanceira { get; set; }

        [ForeignKey("Perfil")]
        public int IdPerfil { get; set; }

        [ForeignKey("InstituicaoFinanceira")]
        public int IdInstituicaoFinanceira { get; set; }
        public bool Permitido { get; set; } = true;
        //propriedades de navegação
        public virtual Perfil Perfil { get; set; }
        public virtual InstituicaoFinanceira InstituicaoFinanceira { get; set; }
    }
}
