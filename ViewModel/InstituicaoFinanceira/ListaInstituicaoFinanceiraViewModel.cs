using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class ListaInstituicaoFinanceiraViewModel:BaseViewModel
    {
         
        public int IdInstituicaoFinanceira { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        [Display(Name="Total de Agências")]
        public int TotalDeAgencias { get; set; }
         [Display(Name="Total de Sócios")]
        public int TotalDeSocios { get; set; }
        
    }
}