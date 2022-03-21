using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class InstituicaoFinanceira : EntidadeBase
    {
        [Key]
        public int IdInstituicaoFinanceira { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }
        public InstituicaoFinanceira()
        {
            this.Agencia = new HashSet<Agencia>();
        }
    }
}