using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaPerfilViewModel
    {
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
          [Display(Name ="Data de Criação")]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Data de Atualização")]
        public DateTime DataAtualizacao { get; set; }
        
    }
}