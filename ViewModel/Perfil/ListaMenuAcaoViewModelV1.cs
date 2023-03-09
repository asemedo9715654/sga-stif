using sga_stif.Models;
using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaMenuAcaoViewModelV1
    {
        [Key]
        public int IdMenuAcao { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<ListaMenuAcaoViewModelV1Helper> ListaMenuAcaoViewModelV1Helper { get; set; }

        public ListaMenuAcaoViewModelV1()
        {
            
        }


        public ListaMenuAcaoViewModelV1(string descricao,int idMenuAcao)
        {
            Descricao = descricao;
            IdMenuAcao = idMenuAcao;
        }


    }

    public class ListaMenuAcaoViewModelV1Helper
    {
        [Key]
        public int IdMenuAcao { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        public ListaMenuAcaoViewModelV1Helper()
        {

        }


        public ListaMenuAcaoViewModelV1Helper(string descricao, int idMenuAcao)
        {
            Descricao = descricao;
            IdMenuAcao = idMenuAcao;
        }


    }

}