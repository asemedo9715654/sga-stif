using System.ComponentModel.DataAnnotations;
using sga_stif.Extensao;
using sga_stif.Models;

namespace sga_stif.ViewModel.Socio
{
    public class ListaSocioViewModel
    {
        public int IdSocio { get; set; }
        [Display(Name = "Número De Sócio")]
        public string NumeroDeSocio { get; set; }
        [Display(Name = "Nome")]
        public string NomeCompleto { get; set; }
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
        public string Sexo { get; set; }
        [Display(Name = "Número de Telefone")]
        public string NumeroDeTelefone { get; set; }

        [Display(Name = "Estado Cívil")]
        public EstadoCivil EstadoCivil { get; set; }

        [Display(Name = "N- Benef")]
        public int TotalBeneficiario { get; set; }

        public int IdAgencia { get; set; }

        [Display(Name = "Instituição Financeira")]
        public string SiglaInstitucaoFinanceira { get; set; }

        [Display(Name = "Agência")]
        public string NomeAgencia { get; set; }

        public ListaSocioViewModel()
        {
            
        }

        public ListaSocioViewModel(Models.Socio k)
        {
            IdSocio = k.IdSocio;
            NumeroDeSocio = k.NumeroDeSocio;
            NomeCompleto = k.NomeCompleto();
            CinBi = k.CinBi;
            Sexo = k.Sexo.GetDescription();
            TotalBeneficiario = k.TotalBeneficiario();
            IdAgencia = k.IdAgencia;
            SiglaInstitucaoFinanceira = k.Agencia.InstituicaoFinanceira.SiglaFormatado();
            NomeAgencia = k.Agencia.Nome;

        }
    }
}