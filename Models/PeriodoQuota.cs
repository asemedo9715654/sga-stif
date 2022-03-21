using System.ComponentModel.DataAnnotations;

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
        public EstadoQuota Estado { get; set; }
        public virtual ICollection<QuotaSocio> QuotaSocio { get; set; }


        public PeriodoQuota( )
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