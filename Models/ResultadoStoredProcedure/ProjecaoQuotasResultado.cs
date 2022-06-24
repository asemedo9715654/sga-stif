using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models.ResultadoStoredProcedure
{
    public class ProjecaoQuotasResultado
    {

        public string Nome { get; set; }
        public int IdSocio { get; set; }
        public string IFS { get; set; }
        [Display(Name = "Nome da Agência")]
        public string AgenciaNome { get; set; }
        [Display(Name = "Montante Atual")]
        public decimal MontanteAtual { get; set; }
        [Display(Name = "Montante com Projeção")]
        public double MontanteComProjecao { get; set; }
        public string nomeIf { get; set; }
        public double MontanteAtualGlobal { get; set; }
        public double MontanteComProjecaoGlobal { get; set; }
    }
}