using sga_stif.ViewModel.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sga_stif.ViewModel.Perfil
{
    public class ListaPerfilInstituicaoFinanceiraViewModel : BaseViewModel
    {
        [Key]
        public int IdPerfilInstituicaoFinanceira { get; set; }

        [ForeignKey("Perfil")]
        public int IdPerfil { get; set; }

        [ForeignKey("InstituicaoFinanceira")]
        public int IdInstituicaoFinanceira { get; set; }
        public bool Permitido { get; set; } = true;
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


    }
}