using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.Models.ResultadoStoredProcedure
{
  public class PosicaoIFsResultado
  {
    public string IFNome { get; set; }
    public string IdInstituicaoFinanceira { get; set; }
    public int TotalSocioAnterior { get; set; }
    public int TotalSocioAtual { get; set; }
    public int TotalColaboradoresAnterior { get; set; }
    public int TotalColaboradoresAtual { get; set; }
    public int TotalQuoataMesAnterior { get; set; }
    public int TotalQuoataMesAtual { get; set; }
    public string Estado { get; set; }


  }


}