using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.Models
{
    public class JoiaSocio : EntidadeBase
    {
        [Key]
        public int IdJoiaSocio { get; set; }
        public decimal Montante { get; set; }
        [ForeignKey("Socio")]
        public int IdSocio { get; set; }
        [ForeignKey("Joia")]
        public int IdJoia { get; set; }
        public EstadoJoiaSocio Estado { get; set; }
        public virtual Socio Socio { get; set; }
        public virtual Joia Joia { get; set; }
    }



    public enum EstadoJoiaSocio
    {
        NaoPago=0,
        Pago=1
    }
}