using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Beneficiario
{
    public class EditaBeneficiarioViewModel
    {
        [Key]
        public int IdBeneficiario { get; set; }
         [Display(Name = "Nome")]
        public string Nome { get; set; }
         [Display(Name = "Apelido")]
        public string Apelido { get; set; }
        [Display(Name = "Gráu de Parentesco")]
        public GrauDeParentesco GrauDeParentesco { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        [Display(Name = "Número de Identificação Fiscal")]
        public string Nif { get; set; }
        [Display(Name = "Cni-BI")]
        public string CinBi { get; set; }
        [Display(Name = "Número de Passaporte")]
        public string NumeroPassaporte { get; set; }
        public int IdSocio { get; set; }
    }
}