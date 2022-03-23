using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Socio
{
    public class SocioViewModel
    {
        [Key]
        public int IdSocio { get; set; }
        [Display(Name = "Fotografia")]
        public byte[]? Foto { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        [Display(Name = "Número de Identificação Fiscal")]
        public string Nif { get; set; }
        [Display(Name = "CIN BI")]
        public string CinBi { get; set; }
        [Display(Name = "Número de Passaporte")]
        public string NumeroPassaporte { get; set; }
        [Display(Name = "Agência")]
        public int IdAgencia { get; set; }
        [Display(Name = "Tipológia de Socio")]
        public int IdTipologiaSocio { get; set; }
        [Display(Name = "Tipo de Quota")]
        public int IdTipoQuota { get; set; }

    }
}