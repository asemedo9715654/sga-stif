using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
  public class InstituicaoFinanceiraColaboradores : EntidadeBase
  {
    [Key]
    public int IdInstituicaoFinanceiraColaboradores { get; set; }

    [ForeignKey("InstituicaoFinanceira")]
    public int IdInstituicaoFinanceira { get; set; }
    public int NumeroColaboradores { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
     //propriedades de navegação
    public virtual InstituicaoFinanceira InstituicaoFinanceira { get; set; }

 
  }
}