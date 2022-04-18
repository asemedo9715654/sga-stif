using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaMenuAcaoViewModelV1
    {
        [Key]
        public int IdMenuAcao { get; set; }
     
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

         public List<ListaMenuAcaoViewModelV1Helper> ListaMenuAcaoViewModelV1Helper { get; set; }
    

    }

    public class ListaMenuAcaoViewModelV1Helper
    {
        [Key]
        public int IdMenuAcao { get; set; }
     
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    

    }

}