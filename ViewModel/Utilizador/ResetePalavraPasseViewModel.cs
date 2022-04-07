using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Utilizador
{
    public class ResetePalavraPasseViewModel
    {
        [Key]

        public int IdUtilizador { get; set; }
        public string PalavraPasse { get; set; }
        public string ConfirmacaoPalavraPasse { get; set; }

    }

}