using System.ComponentModel.DataAnnotations;
using sga_stif.Models;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaMenuAcaoViewModel :  BaseViewModel
    {
        [Key]
        public int IdMenuAcao { get; set; }
        public int? IdAcao { get; set; }
        public int? IdMenu { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
       

    }
}