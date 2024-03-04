using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Base;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class ListaInstituicaoFinanceiraColaboradoresViewModel : BaseViewModel
    {
        public int IdInstituicaoFinanceiraColaboradores { get; set; }
        public int IdInstituicaoFinanceira { get; set; }
        [Display(Name = "Número Total De Colaboradores")]
        public int NumeroColaboradores { get; set; }
        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de Fim")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DataFim { get; set; }

    }
}