using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
    public class ContaCorrenteIFResultado
    {
         public int EstadoQuotaNum { get; set; }
         public int IdQuotaSocio { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Id Sócio")]
        public int IdSocio { get; set; }
        [Display(Name = "Instituição Financeira")]
        public string IFS { get; set; }
        [Display(Name = "Nome da Agência")]
        public string AgenciaNome { get; set; }
        [Display(Name = "Ano")]
        public int Ano { get; set; }
        [Display(Name = "Mês")]
        public string Mes { get; set; }
         public int MesNum { get; set; }
        [Display(Name = "Montante")]
        public decimal Montante { get; set; }

        [Display(Name = "Estado da Quota")]
        public string EstadoQuota { get; set; }


    }


}