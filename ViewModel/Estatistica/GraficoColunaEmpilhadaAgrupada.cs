using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Estatistica
{
   public class GraficoColunaEmpilhadaAgrupada
    {
        public List<string> categorias { get; set; }
        public List<Dados> dados { get; set; }

        public GraficoColunaEmpilhadaAgrupada()
        {
            categorias = new List<string>();
            dados = new List<Dados>();
        }
    }

   
}