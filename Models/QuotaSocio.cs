using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class QuotaSocio : EntidadeBase
    {
        [Key]
        public int IdQuotaSocio { get; set; }
        public decimal Montante { get; set; }
        public EstadoQuotaSocio Estado { get; set; }
        [ForeignKey("Socio")]
        public int IdSocio { get; set; }
        [ForeignKey("PeriodoQuota")]
        public int IdPeriodoQuota { get; set; }
        public virtual Socio Socio { get; set; }
        public virtual PeriodoQuota PeriodoQuota { get; set; }
    }

    public enum EstadoQuotaSocio
    {
        Pago = 1,
        NoaPago = 0
    }
}