namespace sga_stif.Models.ResultadoStoredProcedure
{
    public class ContaHistorialSocioResultado
    {
        public int IdQuotaSocio { get; set; }
        public string Nome { get; set; }
        public string NumeroDeSocio { get; set; }
        public int IdSocio { get; set; }
        public string IFS { get; set; }
        public string AgenciaNome { get; set; }
        public int Ano { get; set; }
        public int MesNum { get; set; }
        public string Mes { get; set; }
        public decimal Montante { get; set; }
        public string EstadoQuota { get; set; }
        public string? mesesPago { get; set; }
        public double? totalMontantePago { get; set; }
    }
}