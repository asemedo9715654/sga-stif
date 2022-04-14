using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class TipoQuota : EntidadeBase
    {
        [Key]
        public int IdTipoQuota { get; set; }
        public string Descricao { get; set; }
        public int Priodicidade { get; set; }
        public decimal Montante { get; set; }
        public TipoTipoQuota Tipo { get; set; }
        public virtual ICollection<Socio> Socio { get; set; }
        // public virtual ICollection<PeriodoQuota> PeriodoQuota { get; set; }

        public TipoQuota()
        {
            Socio = new HashSet<Socio>();
            // PeriodoQuota = new HashSet<PeriodoQuota>();
        }


    }


    public enum TipoTipoQuota
    {
        Variavel,
        Fixo
    }
}