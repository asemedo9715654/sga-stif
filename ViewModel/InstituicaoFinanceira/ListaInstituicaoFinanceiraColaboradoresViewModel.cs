using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
  public class ListaInstituicaoFinanceiraColaboradoresViewModel : BaseViewModel
  {
    public int IdInstituicaoFinanceiraColaboradores { get; set; }
    public int IdInstituicaoFinanceira { get; set; }
    [Display(Name ="Número Total De Colaboradores")]
    public int NumeroColaboradores { get; set; }
    [Display(Name ="Data de Iniicio")]
    public DateTime DataInicio { get; set; }

    [Display(Name ="Data de Fim")]
    public DateTime? DataFim { get; set; }

  }
}