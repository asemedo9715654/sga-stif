using System.ComponentModel;
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
        public int TipoQuota { get; set; }
        public int CodigoPeriodo { get; set; }
        public EstadoQuota Estado { get; set; }
         //propriedades de navegação
        public virtual ICollection<QuotaSocio> QuotaSocio { get; set; }
        
        public PeriodoQuota()
        {
            this.QuotaSocio = new HashSet<QuotaSocio>();
        }
    }

    public enum EstadoQuota
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Inativo")]
        Inativo = 0
    }
}