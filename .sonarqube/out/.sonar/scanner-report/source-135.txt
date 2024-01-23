using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
    public class ResetePalavraPasseViewModel
    {
        [Key]

        public int IdUtilizador { get; set; }
        [Required(ErrorMessage = "A Palavra-Passe atual é necessário", AllowEmptyStrings = false)]
        public string PalavraPasse { get; set; }
        [Required(ErrorMessage = "Confirmação da Palavra-Passe é necessário", AllowEmptyStrings = false)]
        public string ConfirmacaoPalavraPasse { get; set; }

    }

}