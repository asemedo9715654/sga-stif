using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
    public class ContaCorrenteIFResultado
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Id Sócio")]
        public int IdSocio { get; set; }
        [Display(Name = "Instituição Financeira")]
        public string IFS { get; set; }
        [Display(Name = "Nome da Agência")]
        public string AgenciaNome { get; set; }
        [Display(Name = "Ano")]
        public int ano { get; set; }
        [Display(Name = "Mês")]
        public int Mes { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        [Display(Name = "Montante")]
        public decimal Montante { get; set; }
        [Display(Name = "Estado")]
        public int Estado { get; set; }
        [Display(Name = "Id Periodo Quotas")]
        public int IdPeriodoQuota { get; set; }
        [Display(Name = "Estado da Quota")]
        public string EstadoQuota { get; set; }


    }


}