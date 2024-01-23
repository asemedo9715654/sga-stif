using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Joia : EntidadeBase
    {
        [Key]
        public int IdJoia { get; set; }
        public string Descricao { get; set; }
        public decimal Montante { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        //proprieddades de navegacao
        public virtual ICollection<JoiaSocio> JoiaSocio { get; set; }

        public Joia()
        {
            this.JoiaSocio = new HashSet<JoiaSocio>();
        }
    }
}