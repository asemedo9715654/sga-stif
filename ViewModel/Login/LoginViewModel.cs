using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel
{
  public class LoginViewModel
  {
     [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
    public string NomeUtilizador { get; set; }
    [StringLength(16, ErrorMessage = "Must be between 3 and 16 characters", MinimumLength = 3)]
    public string PalavraPasse { get; set; }

  }
}