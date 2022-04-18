using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Beneficiario
{
  public class NovoBeneficiarioViewModel
  {
    [Key]
    public int IdBeneficiario { get; set; }
    
    [Required(ErrorMessage = "O Nome é necessãrio")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O Apelido é necessãrio")]
    public string Apelido { get; set; }

    [Display(Name = "Gráú de Parentesco")]
    [Required(ErrorMessage = "O Graú de Parentesco é necessãrio")]
    public GrauDeParentesco GrauDeParentesco { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "A Data de Nascimento é necessãrio")]
    public DateTime DataDeNascimento { get; set; }

    [Display(Name = "Número de Identificação Fiscal")]
    [Required(ErrorMessage = "O NIF é necessãrio")]
    public string Nif { get; set; }
    [Display(Name = "CNI/BI")]
    [Required(ErrorMessage = "O CNI/BI é necessãrio")]
    public string CinBi { get; set; }
    [Display(Name = "Número de Passaporte")]
    public string NumeroPassaporte { get; set; }
    public int IdSocio { get; set; }
  }
}