using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Beneficiario : EntidadeBase
    {
        [Key]
        public int IdBeneficiario { get; set; }
        public string Nome { get; set; }

    }
}