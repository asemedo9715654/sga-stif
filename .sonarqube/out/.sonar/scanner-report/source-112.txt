using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.MenuAcao
{
    public class ListaMenuViewModel
    {
        [Key]
        public int IdMenu { get; set; }
        public string Nome { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        public string NomeDoController { get; set; }
        public string NomeDaAction { get; set; }
        public string Icone { get; set; }
        [Display(Name ="Tipo de Menu")]

        public string TipoMenu { get; set; }
        public int? IdMenuPai { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Data de Criação")]

        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Data de Atualização")]
        public DateTime? DataAtualizacao { get; set; } = DateTime.Now;
        
    }
}