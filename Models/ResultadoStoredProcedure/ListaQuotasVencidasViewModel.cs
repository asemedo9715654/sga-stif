using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
  public class ListaQuotasVencidasResultado
  {
    public string Nome { get; set; }
    public int IdSocio { get; set; }
    public string IFS { get; set; }
    public string AgenciaNome { get; set; }
    public int ano { get; set; }
    public int Mes { get; set; }
    public string descricao { get; set; }
    public decimal Montante { get; set; }
    public int Estado { get; set; }
    public int IdPeriodoQuota { get; set; }
    public string EstadoQuota { get; set; }

   

  }


}