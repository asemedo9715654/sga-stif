using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaMenuAcaoViewModel
    {
        [Key]
        public int IdMenuAcao { get; set; }
        public int? IdAcao { get; set; }
        public int? IdMenu { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; }
        [Display(Name = "Data de Atualização")]
        public DateTime DataAtualizacao { get; set; }


    }
}