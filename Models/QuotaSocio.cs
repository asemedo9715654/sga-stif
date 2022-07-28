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

        //propriedaddae para efectuar pagamento
         public string? UtilizadorQueEfectuouPagamento { get; set; }
         public DateTime? DataQueFoiEfectuadaPagamento { get; set; }
         public string? UtilizadorQueConfirmouPagamento { get; set; }
         public DateTime? DataQueFoiConfirmadaPagamento { get; set; }

         public string OrigemPagamento { get; set; } = "Manual"; //Ficheiro

         //propriedades de navegação
        public virtual Socio Socio { get; set; }
        public virtual PeriodoQuota PeriodoQuota { get; set; }
    }

    public enum EstadoQuotaSocio
    {
        Vencida = 2,
        Pago = 1,
        NoaPago = 0,
        AguardaConfirmacaoPagamento = -1,
    }
}