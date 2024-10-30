using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace sga_stif.Models
{
    public class Ilha : EntidadeBase
    {
        [Key]
        public int IdIlha { get; set; }
        public string Nome { get; set; }
        public string? Regiao { get; set; }
        //propriedades de navegação
        public virtual ICollection<Cidade> Cidade { get; set; }

        public Ilha()
        {
            this.Cidade = new HashSet<Cidade>();
        }

        // Método para calcular o total de sócios em todas as cidades da ilha
        public int TotalSocios()
        {
            int totalSocios = 0;

            // Percorre todas as cidades e suas respectivas agências
            foreach (var cidade in Cidade)
            {
                foreach (var agencia in cidade.Agencia)
                {
                    // Soma o número de sócios em cada agência
                    totalSocios += agencia.Socio.Count();
                }
            }

            return totalSocios;
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


        // Método para obter todos os sócios por Ilha
        public List<Socio> ObterSocios()
        {
            var todosSocios = new List<Socio>();

            foreach (var cidade in Cidade)
            {
                foreach (var agencia in cidade.Agencia)
                {
                    todosSocios.AddRange(agencia.Socio);
                }
            }
            return todosSocios;
        }
    }
}