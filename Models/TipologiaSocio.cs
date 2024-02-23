using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class TipologiaSocio : EntidadeBase
    {
        [Key]
        public int IdTipologiaSocio { get; set; }
        public TipoTipologiaSocio Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        //propriedades de navegação
        public virtual ICollection<Socio> Socio { get; set; }

        public TipologiaSocio()
        {
            this.Socio = new HashSet<Socio>();
        }

        public int TotalDeSocios() => Socio.Count();
    }


    public enum TipoTipologiaSocio
    {
        [Description("Normal")]
        Normal,
        [Description("Honorário")]
        Honorario
    }
}