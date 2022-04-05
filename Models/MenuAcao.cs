using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class MenuAcao : EntidadeBase
    {
        [Key]
        public int IdMenuAcao { get; set; }

        [ForeignKey("Acao")]
        public int? IdAcao { get; set; }
        [ForeignKey("Menu")]
        public int? IdMenu { get; set; }
        public virtual Acao? Acao { get; set; }
        public virtual Menu? Menu { get; set; }
         public bool MenuAcaoMaster { get; set; } = false;
        public virtual ICollection<PerfilMenuAcao> PerfilMenuAcao { get; set; }
        public MenuAcao()
        {
            this.PerfilMenuAcao = new HashSet<PerfilMenuAcao>();
        }


    }
}