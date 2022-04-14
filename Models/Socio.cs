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

        [ForeignKey("Agencia")]
        public int IdAgencia { get; set; }
        [ForeignKey("TipologiaSocio")]
        public int IdTipologiaSocio { get; set; }
        [ForeignKey("TipoQuota")]
        public int IdTipoQuota { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataAtivacao { get; set; }
        public string NumeroColaborador  { get; set; }

        //propriedades de navegacao
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


        public void GerarNumeroSocio()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; 
            this.NumeroDeSocio = new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }


    public enum Sexo
    {
        Feminino,
        Masculino
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