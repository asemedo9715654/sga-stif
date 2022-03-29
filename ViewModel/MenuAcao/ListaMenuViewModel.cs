using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.MenuAcao
{
    public class ListaMenuViewModel
    {
        [Key]
        public int IdMenu { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string NomeDoController { get; set; }
        public string NomeDaAction { get; set; }
        public string Icone { get; set; }
        public string TipoMenu { get; set; }
        public int? IdMenuPai { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataAtualizacao { get; set; } = DateTime.Now;
        
    }
}