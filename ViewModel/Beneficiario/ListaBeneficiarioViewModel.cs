using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Beneficiario
{
    public class ListaBeneficiarioViewModel
    {
        [Key]
        public int IdBeneficiario { get; set; }
        public int IdSocio { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        [Display(Name = "Graú de Parentesco")]
        public GrauDeParentesco GrauDeParentesco { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        [Display(Name = "Número de Identificação Fiscal")]
        public string Nif { get; set; }
        [Display(Name = "CNI/BI")]
        public string CinBi { get; set; }
        [Display(Name = "Número de Passaporte")]
        public string NumeroPassaporte { get; set; }
    }
}