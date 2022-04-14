using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
    public class NovoPerfilViewModel
    {
        public string Nome { get; set; }
           [Display(Name ="Descrição")]
        public string Descricao { get; set; }

       
        
    }
}