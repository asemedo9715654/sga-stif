using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
  public class Socio : EntidadeBase
  {
    [Key]
    public int IdSocio { get; set; }
    public string NumeroDeSocio { get; set; }
    public byte[]? Foto { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Nif { get; set; }
    public string CinBi { get; set; }
    public DateTime ValidadeCinBi { get; set; }
    public string NumeroPassaporte { get; set; }
    public DateTime ValidadePassaporte { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public Sexo Sexo { get; set; }
    public EstadoCivil EstadoCivil { get; set; }
    public string? NumeroDeTelefone { get; set; }
    public string? NumeroDeTelemovel { get; set; }
    public string Email { get; set; }

    public DateTime? DataInicio { get; set; }
    public DateTime? DataAtivacao { get; set; } = DateTime.Now.Date;
    public string NumeroColaborador { get; set; }
    public EstadoDeSocio EstadoSocio { get; set; }

    //chaves estrangeiras

    [ForeignKey("Agencia")]
    public int IdAgencia { get; set; }
    [ForeignKey("TipologiaSocio")]
    public int IdTipologiaSocio { get; set; }
    [ForeignKey("TipoQuota")]
    public int IdTipoQuota { get; set; }


    //propriedades de navegação
    public virtual Agencia Agencia { get; set; }
    public virtual TipologiaSocio TipologiaSocio { get; set; }
    public virtual TipoQuota TipoQuota { get; set; }
    public virtual ICollection<JoiaSocio> JoiaSocio { get; set; }
    public virtual ICollection<QuotaSocio> QuotaSocio { get; set; }
    public virtual ICollection<Beneficiario> Beneficiario { get; set; }

    public Socio()
    {
      this.JoiaSocio = new HashSet<JoiaSocio>();
      this.QuotaSocio = new HashSet<QuotaSocio>();
      this.Beneficiario = new HashSet<Beneficiario>();
    }



     public void PrepararSocioSocio(Socio socio)
    {
      this.NumeroColaborador = socio.NumeroColaborador;
      this.NumeroDeSocio = socio.NumeroDeSocio;
    }

    public int TotalBeneficiario()
    {
      return Beneficiario.Count();
    }

    public string NomeCompleto()
    {
      return this.Nome + " " + this.Apelido;
    }


    public void GerarNumeroSocio()
    {
      Random random = new Random();
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      this.NumeroDeSocio = new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());
    }


    public string PegarLinkFotoGrande()
    {
      if (Foto != null)
      {

        var aux = Convert.ToBase64String(Foto);
        string imageDataURL = string.Format("data:image/png;base64,{0}", aux);
        return imageDataURL;
      }
      else
      {
        return "~/dist/img/user4-128x128.jpg";

      }
    }

  }


  public enum Sexo
  {
    Feminino,
    Masculino
  }

  public enum EstadoDeSocio
  {
    Ativo = 1,
    Inativo = 0
  }


  public enum EstadoCivil
  {
    Solteiro,
    Viuvo,
    Casado,
    Divorciado,
    SeparacaoJudicial,

  }
}