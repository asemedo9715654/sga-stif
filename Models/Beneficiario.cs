using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
  public class Beneficiario : EntidadeBase
  {
    [Key]
    public int IdBeneficiario { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public GrauDeParentesco GrauDeParentesco { get; set; }
    public string? Nif { get; set; }
    public string? CinBi { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public string? NumeroPassaporte { get; set; }

    //chaves estrangeiras
    [ForeignKey("Socio")]
    public int IdSocio { get; set; }
    //propriedaddes de navegacao
    public virtual Socio Socio { get; set; }

  }


  public enum GrauDeParentesco
  {
     [Description("ESPOSO")]
    Esposo,
     [Description("ESPOSA")]
    Esposa,
    [Description("FILHO")]
    Filho,
    [Description("FILHA")]
    Filha,
    [Description("PAI")]
    Pai,
    [Description("MÃE")]
    Mae
  }
}