using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Ilha : EntidadeBase
    {
        [Key]
        public int IdIlha { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
       
        public Ilha()
        {
            this.Cidade = new HashSet<Cidade>();
        }
    }
}