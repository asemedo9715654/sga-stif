using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace sga_stif.Models
{
    public class InstituicaoFinanceira : EntidadeBase
    {
        [Key]
        public int IdInstituicaoFinanceira { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        //propriedades de navegação
        public virtual ICollection<Agencia> Agencia { get; set; }
        public virtual ICollection<InstituicaoFinanceiraColaboradores> InstituicaoFinanceiraColaboradores { get; set; }
        public virtual ICollection<PerfilInstituicaoFinanceira> PerfilInstituicaoFinanceira { get; set; }
        public InstituicaoFinanceira()
        {
            this.Agencia = new HashSet<Agencia>();
            this.InstituicaoFinanceiraColaboradores = new HashSet<InstituicaoFinanceiraColaboradores>();
            this.PerfilInstituicaoFinanceira = new HashSet<PerfilInstituicaoFinanceira>();
        }

        public int TotalAgencias()
        {
            return Agencia.Count();
        }

        public int TotalSocios()
        {
            var somaSocios = 0;
            foreach (var item in Agencia)
                somaSocios += item.TotalSocios();
            return somaSocios;
        }

        public string SiglaFormatado()
        {

            var siglaTransformado = "";
            var siglaBruto = Regex.Replace(this.Sigla, @"\s+", " "); //remover mais de um espaço
            siglaBruto = siglaBruto.Trim();
            var palavras = siglaBruto.Split(' ');

            foreach (var palavra in palavras)
                siglaTransformado = siglaTransformado + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();

            return siglaTransformado;
        }


        public string NomeFormatado()
        {
            var siglaTransformado = "";
            var siglaBruto = Regex.Replace(this.Sigla, @"\s+", " "); //remover mais de um espaço
            siglaBruto = siglaBruto.Trim();
            var palavras = siglaBruto.Split(' ');

            foreach (var palavra in palavras)
                siglaTransformado = siglaTransformado + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();

            return siglaTransformado;
        }
    }
}