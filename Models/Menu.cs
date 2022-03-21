using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Menu : EntidadeBase
    {
        [Key]
        public int IdMenu { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? IdMenuPai { get; set; }
        public virtual ICollection<MenuAcao> MenuAcao { get; set; }


        public Menu()
        {
            this.MenuAcao = new HashSet<MenuAcao>();
        }

        public string Categoria()
        {
            return IdMenuPai == null ? "Menu" : "Sub-Menu";
        }
    }
}