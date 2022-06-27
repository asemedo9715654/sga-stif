using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace sga_stif.Models
{
    public class Agencia : EntidadeBase
    {
        [Key]
        public int IdAgencia { get; set; }
        public string Nome { get; set; }

        //chaves estrangeiras
        [ForeignKey("Cidade")]
        public int IdCidade { get; set; }
        [ForeignKey("InstituicaoFinanceira")]
        public int IdInstituicaoFinanceira { get; set; }

        //propriedaddes dde navegacao
        public virtual Cidade Cidade { get; set; }
        public virtual InstituicaoFinanceira InstituicaoFinanceira { get; set; }
        public virtual ICollection<Socio> Socio { get; set; }

        public Agencia()
        {
            this.Socio = new HashSet<Socio>();
        }


        public int TotalSocios()
        {
            return Socio.Count();
        }


        public string NomeFormatado()
        {
            var nomeCompleto = "";

            var nomeCopletoSemTratamento = this.Nome;

            nomeCopletoSemTratamento = Regex.Replace(nomeCopletoSemTratamento, @"\s+", " ");

            nomeCopletoSemTratamento = nomeCopletoSemTratamento.Trim();

            string[] palavras = nomeCopletoSemTratamento.Split(' ');

            foreach (var palavra in palavras)
            {
                nomeCompleto = nomeCompleto + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();
            }

            return nomeCompleto;

        }
    }
}