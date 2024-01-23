using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel
{
    public class LoginViewModel
    {
        [StringLength(16, ErrorMessage = "Deve ter entre 3 e 16 caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "O nome do utilizador é necessário")]
        public string NomeUtilizador { get; set; }

        [StringLength(16, ErrorMessage = "Deve ter entre 3 e 16 caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "A palavra passe é necessário")]
        public string PalavraPasse { get; set; }

    }
}