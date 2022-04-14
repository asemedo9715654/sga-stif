using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.MenuAcao
{
    public class DadosComponente
    {
        public int IdMenuAcao { get; set; }
        public int IdMenu { get; set; }
        public int IdAcao { get; set; }
        public bool Preenchido { get; set; }
      
    }
}