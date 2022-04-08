using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class InstituicaoFinanceira : EntidadeBase
    {
        [Key]
        public int IdInstituicaoFinanceira { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }
        public InstituicaoFinanceira()
        {
            this.Agencia = new HashSet<Agencia>();
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