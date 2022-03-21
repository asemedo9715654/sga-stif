using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class EntidadeBase
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataAtualizacao { get; set; } = DateTime.Now;
        public bool? Eliminado { get; set; } = false;
    }

}