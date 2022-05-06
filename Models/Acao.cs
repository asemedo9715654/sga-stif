using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
  public class Acao : EntidadeBase
  {
    [Key]
    public int IdAcao { get; set; }
    public string Nome { get; set; }
    public bool AcaoMaster { get; set; } = false;
    //propriedades de navegacao
    public virtual ICollection<MenuAcao> MenuAcao { get; set; }


    public Acao()
    {
      this.MenuAcao = new HashSet<MenuAcao>();
    }
  }
}