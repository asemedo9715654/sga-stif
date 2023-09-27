using System.ComponentModel.DataAnnotations;
namespace sga_stif.ViewModel.Utilizador
{
    public class MudaPalavraPasseViewModel
    {
          [Display(Name = "Palavra-Passe Antigo")]
        public string PalavraPasseAntiga { get; set; }
          [Display(Name = "Nova Palavra-Passe")]
        public string NovaPalavraPasse { get; set; }
         [Display(Name = "Confirmação da Nova Palavra-Passe")]
        public string ConfirmacaoNovaPalavraPasse { get; set; }
    }
}
