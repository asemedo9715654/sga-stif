using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class NovoInstituicaoFinanceiraViewModel
    {
        [Display(Name="Nome")]
        [Required(ErrorMessage ="O Nome da Instituição é necessário!")]
        public string Nome { get; set; }
        
    }
}