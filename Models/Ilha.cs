using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace sga_stif.Models
{
    public class Ilha : EntidadeBase
    {
        [Key]
        public int IdIlha { get; set; }
        public string Nome { get; set; }
        //propriedades de navegação
        public virtual ICollection<Cidade> Cidade { get; set; }

        public Ilha()
        {
            this.Cidade = new HashSet<Cidade>();
        }


        public string NomeFormatado()
        {
            var nomeCompleto = "";

            var nomeCopletoSemTratamento = this.Nome;

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
}