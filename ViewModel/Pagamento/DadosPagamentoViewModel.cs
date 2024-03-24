using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using sga_stif.Models;

namespace sga_stif.ViewModel.Pagamento
{
    public class DadosPagamentoViewModel
    {
        public int IdQuotaSocio { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Display(Name = "Institução Financeira")]
        public string InstitucaoFinanceira { get; set; }

        [Display(Name = "Agência")]
        public string Agencia { get; set; }

        [Display(Name = "Ilha")]
        public string Ilha { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        
        [Display(Name = "Mês")]
        public string Mes { get; set; }
        public int Ano { get; set; }
        public string Url { get; set; }

        [Display(Name = "Montante")]
        [Required(ErrorMessage = "O Montante é necessãrio")]
        [Range(1, Double.MaxValue, ErrorMessage = "O cammpo {0} tem de ser maior que {1}.")]
        public decimal Montante { get; set; }

        public DadosPagamentoViewModel()
        {
            
        }

        public DadosPagamentoViewModel(QuotaSocio quotaSocio,string nomeDoMes,string url)
        {
            Apelido = quotaSocio.Socio.Apelido;
            IdQuotaSocio = quotaSocio.IdQuotaSocio;
            Nome = quotaSocio.Socio.Nome;
            InstitucaoFinanceira = quotaSocio.Socio.Agencia.InstituicaoFinanceira.Nome;
            Agencia = quotaSocio.Socio.Agencia.Nome;
            Cidade = quotaSocio.Socio.Agencia.Cidade.Nome;
            Ilha = quotaSocio.Socio.Agencia.Cidade.Ilha.Nome;
            Ano = quotaSocio.PeriodoQuota.Ano;
            Mes = nomeDoMes;
            Url = url;
            //Montante = quotaSocio.Montante
        }
         

    }
}