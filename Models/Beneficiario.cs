using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

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

        public string NomeCompleto()
        {
            var nomeCompleto = "";
            var nomeCopletoSemTratamento = this.Nome + " " + this.Apelido;
            nomeCopletoSemTratamento = Regex.Replace(nomeCopletoSemTratamento, @"\s+", " ");
            nomeCopletoSemTratamento = nomeCopletoSemTratamento.Trim();
            var palavras = nomeCopletoSemTratamento.Split(' ');

            foreach (var palavra in palavras)
            {
                nomeCompleto = nomeCompleto + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();
            }

            return nomeCompleto;

        }
    }


    public enum GrauDeParentesco
    {
        [Description("Esposo")]
        Esposo,
        [Description("Esposa")]
        Esposa,
        [Description("Filho")]
        Filho,
        [Description("Filha")]
        Filha,
        [Description("Pai")]
        Pai,
        [Description("Mãe")]
        Mae
    }
}