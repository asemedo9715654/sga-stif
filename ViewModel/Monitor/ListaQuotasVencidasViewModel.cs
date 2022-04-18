using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Monitor
{
  public class ListaQuotasVencidasViewModel
  {
    public int Ano { get; set; }
    public int Mes { get; set; }
    public int NumeroDeAssociado { get; set; }
    public decimal MontanteParaPagar { get; set; }
    public EstadoListaQuotasVencidasViewModel Estado { get; set; }
   
  
    public static List<ListaQuotasVencidasViewModel> DadosFalso()
    {
       List<ListaQuotasVencidasViewModel> dadosFalso = new List<ListaQuotasVencidasViewModel>();

       for (int i = 0; i < 30; i++)
       {
         dadosFalso.Add(new ListaQuotasVencidasViewModel(){
           Ano=2022,
           Estado = i%2==0?EstadoListaQuotasVencidasViewModel.PAGO:EstadoListaQuotasVencidasViewModel.NAOPAGO,
           Mes = 12,
           MontanteParaPagar = 200*i+239,
           NumeroDeAssociado =1,
          
         });

       }

       return dadosFalso;

    }



  }


  public enum  EstadoListaQuotasVencidasViewModel{
    PAGO,
    NAOPAGO

  }



}