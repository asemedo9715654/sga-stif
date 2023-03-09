using sga_stif.ViewModel.Pagamento;
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
        public string? UtilizadorQueEfectuouPagamento { get; set; }
        public DateTime? DataQueFoiEfectuadaPagamento { get; set; }
        public string? UtilizadorQueConfirmouPagamento { get; set; }
        public DateTime? DataQueFoiConfirmadaPagamento { get; set; }

        public string OrigemPagamento { get; set; } = "Manual"; //Ficheiro

        //propriedades de navegação
        public virtual Socio Socio { get; set; }
        public virtual PeriodoQuota PeriodoQuota { get; set; }


        public void DadosPrimeiroPagamento(string nomeUtilizador,decimal montante)
        {
            OrigemPagamento = "Manual";
            Estado = EstadoQuotaSocio.AguardaConfirmacaoPagamento;
            Montante = montante;
            DataQueFoiEfectuadaPagamento = DateTime.Now;
            UtilizadorQueEfectuouPagamento = nomeUtilizador;
            DataAtualizacao = DateTime.Now;
        }

        public void FinalizarPagamento(string nomeUtilizador)
        {
            Estado = EstadoQuotaSocio.Pago;
            DataQueFoiConfirmadaPagamento = DateTime.Now;
            UtilizadorQueConfirmouPagamento = nomeUtilizador;
            DataAtualizacao = DateTime.Now;
        }

        public void AnularPagamento(string nomeUtilizador)
        {
            Estado = EstadoQuotaSocio.NoaPago;
            DataQueFoiConfirmadaPagamento = DateTime.Now;
            UtilizadorQueConfirmouPagamento = nomeUtilizador;
            DataAtualizacao = DateTime.Now;
            Montante = 0;
        }

    }

    public enum EstadoQuotaSocio
    {
        Vencida = 2,
        Pago = 1,
        NoaPago = 0,
        AguardaConfirmacaoPagamento = -1,
    }
}