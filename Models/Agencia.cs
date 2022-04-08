using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class Agencia : EntidadeBase
    {
        [Key]
        public int IdAgencia { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Cidade")]
        public int IdCidade { get; set; }
        [ForeignKey("InstituicaoFinanceira")]
        public int IdInstituicaoFinanceira { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual InstituicaoFinanceira InstituicaoFinanceira { get; set; }
        public virtual ICollection<Socio> Socio { get; set; }

        public Agencia()
        {
            this.Socio = new HashSet<Socio>();
        }


         public int TotalSocios()
        {
            return Socio.Count();
        }
    }
}