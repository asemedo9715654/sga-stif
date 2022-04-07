using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
    public class OutossssViewModel
    {
        [Key]
        public int IdMenuAcao { get; set; }
     
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

         public List<Dadosdddd>     Dadosdddd { get; set; }
    

    }



    public class Dadosdddd
    {
        [Key]
        public int IdMenuAcao { get; set; }
     
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
      



    }




}