using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class TipologiaSocio : EntidadeBase
    {
        [Key]
        public int IdTipologiaSocio { get; set; }
        // public decimal Montante { get; set; }
        // public int Prioridicidade { get; set; }
        public TipoTipologiaSocio Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public virtual ICollection<Socio> Socio { get; set; }

        public TipologiaSocio()
        {
            this.Socio = new HashSet<Socio>();
        }

        public int TotalDeSocios()
        {
            return Socio.Count();
        }
    }


    public enum TipoTipologiaSocio
    {
        Normal,
        Honorario
    }
}