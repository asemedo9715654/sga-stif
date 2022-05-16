using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Agencia
{
    public class EditaAgenciaViewModel
    {
        public int IdAgencia { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome da Agência é necessário!")]
        public string Nome { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "A cidade da Agência é necessário!")]
        public int IdCidade { get; set; }
        [Display(Name = "Instituição Financeira")]
        [Required(ErrorMessage = "A Instituição Financeira da Agência é necessário!")]
        public int IdInstituicaoFinanceira { get; set; }
    }
}