using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class Perfil : EntidadeBase
    {
        [Key]
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
         public bool Editavel { get; set; } = true;
        public virtual  ICollection<Utilizador> Utilizador { get; set; }
        public virtual  ICollection<PerfilMenuAcao> PerfilMenuAcao { get; set; }


        public Perfil()
        {
            this.Utilizador = new HashSet<Utilizador>();
            this.PerfilMenuAcao = new HashSet<PerfilMenuAcao>();
        }


         public int TotalUtilizadores()
        {
            return Utilizador.Count();
        }

    }
}