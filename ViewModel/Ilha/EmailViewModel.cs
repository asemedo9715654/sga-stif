using System.ComponentModel.DataAnnotations;
using sga_stif.Models;
namespace sga_stif.ViewModel.Ilha;

public class EmailIlhaViewModel
{
    public int IdIlha { get; set; }
    public string Assunto { get; set; }
    public string Sexo { get; set; }
    [Display(Name = "Texto do e-mail")]
    public string CorpoDoEmail { get; set; }


}