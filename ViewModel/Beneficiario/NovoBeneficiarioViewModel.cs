using System.ComponentModel.DataAnnotations;
using sga_stif.Models;
using Microsoft.AspNetCore.Mvc;
 
namespace sga_stif.ViewModel.Beneficiario
{
  public class NovoBeneficiarioViewModel
  {
    [Key]
    public int IdBeneficiario { get; set; }
    
    [Required(ErrorMessage = "O Nome é necessário")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O Apelido é necessário")]
    public string Apelido { get; set; }

    [Display(Name = "Gráú de Parentesco")]
    [Required(ErrorMessage = "O Graú de Parentesco é necessário")]
    public GrauDeParentesco GrauDeParentesco { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "A Data de Nascimento é necessário")]
    public DateTime DataDeNascimento { get; set; }

    [Display(Name = "Número de Identificação Fiscal")]
    [Required(ErrorMessage = "O NIF é necessário")]
    public string Nif { get; set; }
    [Display(Name = "CNI/BI")]
    [Required(ErrorMessage = "O CNI/BI é necessário")]
    [Remote(action: "VereficaCniBi", controller: "Beneficiario")]
    public string CinBi { get; set; }
    [Display(Name = "Número de Passaporte")]
    public string NumeroPassaporte { get; set; }
    public int IdSocio { get; set; }
  }
}