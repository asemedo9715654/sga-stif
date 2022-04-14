using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
    public class EditaPerfilViewModel
    {
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

       
        
    }
}