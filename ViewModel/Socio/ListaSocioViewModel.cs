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
        public string Sexo { get; set; }
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

        public ListaSocioViewModel(Models.Socio socio)
        {
            IdSocio = socio.IdSocio;
            NumeroDeSocio = socio.NumeroDeSocio;
            NomeCompleto = socio.NomeCompleto();
            CinBi = socio.CinBi;
            Sexo = socio.Sexo.GetDescription();
            TotalBeneficiario = socio.TotalBeneficiario();
            IdAgencia = socio.IdAgencia;
            SiglaInstitucaoFinanceira = socio.Agencia.InstituicaoFinanceira.SiglaFormatado();
            NomeAgencia = socio.Agencia.Nome;

        }
    }
}