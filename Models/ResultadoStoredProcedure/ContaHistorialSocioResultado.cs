using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models.ResultadoStoredProcedure
{
    public class ContaHistorialSocioResultado
    {
        public int IdQuotaSocio { get; set; }
        public string Nome { get; set; }
        public string NumeroDeSocio { get; set; }
        public int IdSocio { get; set; }
        [Display(Name = "Instituição Financeira")]
        public string IFS { get; set; }
        [Display(Name = "Nome da Agência")]
        public string AgenciaNome { get; set; }
        public int Ano { get; set; }
        public int MesNum { get; set; }
        [Display(Name = "Mês")]
        public string Mes { get; set; }
        public decimal Montante { get; set; }
        [Display(Name = "Estado Quota")]
        public string EstadoQuota { get; set; }
        public string? mesesPago { get; set; }
        public double? totalMontantePago { get; set; }
    }
}