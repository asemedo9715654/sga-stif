using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace sga_stif.Models
{
    public class Cidade : EntidadeBase
    {
        [Key]
        public int IdCidade { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Ilha")]
        public int IdIlha { get; set; }

        //propriedades de navegação
        public virtual Ilha Ilha { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }


        public Cidade()
        {
            this.Agencia = new HashSet<Agencia>();
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