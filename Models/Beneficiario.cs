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
    public string Nif { get; set; }
    public string CinBi { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public string NumeroPassaporte { get; set; }
    [ForeignKey("Socio")]
    public int IdSocio { get; set; }
    public virtual Socio Socio { get; set; }

  }


  public enum GrauDeParentesco
  {
    Esposo,
    Esposa,
    Filho
  }
}