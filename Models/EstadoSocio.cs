using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class EstadoSocio
    {
        [Key]
        public int IdEstadoSocio { get; set; }
        public EstadoEstadoSocio Estado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        [ForeignKey("Socio")]
        public int IdSocio { get; set; }
        public virtual Socio Socio { get; set; }

    }

    public enum EstadoEstadoSocio
    {
        Ativo = 1,
        Inativo = 0
    }
}