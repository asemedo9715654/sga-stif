using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class EditaInstituicaoFinanceiraViewModel
    {
        public int IdInstituicaoFinanceira { get; set; }
        public string Nome { get; set; }
          
          [Required(ErrorMessage ="A Sigla da Instituição é necessário!")]

           public string Sigla { get; set; }

    }
}