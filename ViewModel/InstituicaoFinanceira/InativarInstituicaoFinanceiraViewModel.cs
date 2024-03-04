using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class InativarInstituicaoFinanceiraViewModel : BaseViewModel
    {
        public int IdInstituicaoFinanceira { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome da Instituição é necessário!")]
        [Remote(action: "VereficaNome", controller: "InstituicaoFinanceira")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Sigla da Instituição é necessário!")]
        public string Sigla { get; set; }

    }
}