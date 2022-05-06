using System.ComponentModel.DataAnnotations;

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
        public InstituicaoFinanceira()
        {
            this.Agencia = new HashSet<Agencia>();
            this.InstituicaoFinanceiraColaboradores = new HashSet<InstituicaoFinanceiraColaboradores>();
        }

        public int TotalAgencias()
        {
            return Agencia.Count();
        }
        public int TotalSocios()
        {
            int somaSocios = 0;
            foreach (var item in Agencia)
            {
                somaSocios += item.TotalSocios();
            } 
            return somaSocios;
        }
    }
}