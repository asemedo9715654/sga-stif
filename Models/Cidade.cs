using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class Cidade : EntidadeBase
    {
        [Key]
        public int IdCidade { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Ilha")]
        public int IdIlha { get; set; }
        public virtual Ilha Ilha { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }


        public Cidade()
        {
            this.Agencia = new HashSet<Agencia>();
        }
    }
}