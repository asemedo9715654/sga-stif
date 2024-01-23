using sga_stif.Models;
using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models.ResultadoStoredProcedure
{
    public class ReconciliacaoEntreMesesResultado
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Número do Sócio")]
        public string NumeroDeSocio { get; set; }
        public int IdInstituicaoFinanceira { get; set; }
        public int IdSocio { get; set; }
        public double? MontanteAnt { get; set; }
        public double? MontanteAtual { get; set; }
        public string? OBS { get; set; }


    }


}