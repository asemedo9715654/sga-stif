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

        [Display(Name = "Montante")]
        [Required(ErrorMessage = "O Montante é necessãrio")]

        public decimal Montante { get; set; }

    }
}