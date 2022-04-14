using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class PeriodoQuota : EntidadeBase
    {
        [Key]
        public int IdPeriodoQuota { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int CodigoPeriodo { get; set; }
        public EstadoQuota Estado { get; set; }
        public virtual ICollection<QuotaSocio> QuotaSocio { get; set; }
        // [ForeignKey("TipoQuota")]
        // public int IdTipoQuota { get; set; }
        // public virtual TipoQuota TipoQuota { get; set; }


        public PeriodoQuota()
        {
            this.QuotaSocio = new HashSet<QuotaSocio>();
        }
    }


    public enum EstadoQuota
    {
        Ativo = 1,
        Inativo = 0
    }
}