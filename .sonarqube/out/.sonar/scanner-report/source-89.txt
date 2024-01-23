using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Agencia
{
    public class ListaAgenciaViewModel
    {
        [Key]
        public int IdAgencia { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Cidade")]
        public string NomeCidade { get; set; }
        
        [Display(Name = "Instituição Financeira")]
        public string NomeInstituicaoFinanceira { get; set; }

         [Display(Name = "Total de Sócios")]
        public int TotalDeSocios { get; set; }
        public int IdCidade { get; set; }
        public int IdInstituicaoFinanceira { get; set; }
    }
}