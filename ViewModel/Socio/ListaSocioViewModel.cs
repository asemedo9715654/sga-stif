using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Socio
{
    public class ListaSocioViewModel
    {
        public int IdSocio { get; set; }
        [Display(Name = "Número De Sócio")]
        public string NumeroDeSocio { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        // [Display(Name = "Número de Identificação Fiscal")]
        [Display(Name = "NIF")]
        public string Nif { get; set; }
        [Display(Name = "CNI/BI")]
        public string CinBi { get; set; }
        [Display(Name = "Número de Passaporte")]
        public string NumeroPassaporte { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        public Sexo Sexo { get; set; }
        [Display(Name = "Número de Telefone")]
        public string NumeroDeTelefone { get; set; }

        [Display(Name = "Estado Cívil")]
         public EstadoCivil EstadoCivil { get; set; }
    }
}