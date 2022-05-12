using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Estatistica
{
   public class GraficoColunaEmpilhadaAgrupada
    {
        public List<string> categorias { get; set; }
        public List<Dados> dados { get; set; }
    }

    public class Dados
    {
        public string name { get; set; }
        public List<int> data { get; set; }
    }
}