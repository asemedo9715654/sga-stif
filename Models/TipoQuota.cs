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
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TipoTipoQuota Tipo { get; set; }
        public virtual ICollection<Socio> Socio { get; set; }


    }


    public enum TipoTipoQuota
    {
        TipoQutoA,
        TipoQutoB
    }
}