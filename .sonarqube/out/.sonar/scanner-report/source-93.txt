using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Beneficiario
{
    public class ListaBeneficiarioViewModel
    {
        [Key]
        public int IdQuotaSocio { get; set; }
        public int IdBeneficiario { get; set; }
        public int IdSocio { get; set; }
        [Display(Name = "Nome")]
        public string NomeCompleto { get; set; }
        [Display(Name = "Graú de Parentesco")]
        public string GrauDeParentesco { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        [Display(Name = "NIF")]
        public string Nif { get; set; }
        [Display(Name = "CNI/BI")]
        public string CinBi { get; set; }
        [Display(Name = "Número de Passaporte")]
        public string NumeroPassaporte { get; set; }
    }
}