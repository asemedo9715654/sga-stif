using System.ComponentModel.DataAnnotations;
using sga_stif.Models;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaPerfilViewModel : BaseViewModel
    {
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
         public int TotalUtilizadores { get; set; }

        public bool Editavel { get; set; } 

        

    }
}