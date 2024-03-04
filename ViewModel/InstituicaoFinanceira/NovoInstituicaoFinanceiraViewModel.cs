using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class NovoInstituicaoFinanceiraViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome da Instituição é necessário!")]
        [Remote(action: "VereficaNome", controller: "InstituicaoFinanceira")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Sigla da Instituição é necessário!")]
        public string Sigla { get; set; }

    }
}