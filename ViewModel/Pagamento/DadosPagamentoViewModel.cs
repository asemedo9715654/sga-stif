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

    [Display(Name = "Montante")]
    [Required(ErrorMessage = "O Montante é necessãrio")]
    [Range(1, Double.MaxValue, ErrorMessage = "O cammpo {0} tem de ser maior que {1}.")]

    public decimal Montante { get; set; }
    

  }
}