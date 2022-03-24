using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Beneficiario
{
    public class ListaBeneficiarioViewModel
    {
        [Key]
        public int IdBeneficiario { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public GrauDeParentesco GrauDeParentesco { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataDeNascimento { get; set; }
        public string Nif { get; set; }
        public string CinBi { get; set; }
        public string NumeroPassaporte { get; set; }
    }
}