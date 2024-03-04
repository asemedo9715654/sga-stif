using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class DetalhesInstituicaoFinanceiraViewModel : BaseViewModel
    {
        public int IdInstituicaoFinanceira { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int TotalAgencias { get; set; }
        public List<ListaInstituicaoFinanceiraColaboradoresViewModel> ListaInstituicaoFinanceiraColaboradoresViewModel { get; set; }

    }
}