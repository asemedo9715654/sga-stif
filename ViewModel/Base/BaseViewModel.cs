using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Base
{
    public class BaseViewModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Criação")]
        public DateTime? DataCriacao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Atualização")]
        public DateTime? DataAtualizacao { get; set; }
        public bool? Eliminado { get; set; } = false;

    }
}