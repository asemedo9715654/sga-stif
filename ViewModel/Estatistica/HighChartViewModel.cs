using sga_stif.Extensao;
using sga_stif.Models;
using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Estatistica
{
    public class HighChartSeries
    {
        public string type { get; set; }
        public string name { get; set; }
        public bool colorByPoint { get; set; }
        public List<data> data { get; set; }


        public HighChartSeries()
        {
            
        }
        
        public HighChartSeries(string name)
        {
            this.name = name;
            colorByPoint = true;
            data = new List<data>();
        }

        public void PreencherDadosIlhas(List<Ilha> ilhas,List<int> listaDeSocio)
        {
            foreach (var item in ilhas)
            {
                var agencia = new List<int>();
                foreach (var ilha in item.Cidade)
                {
                    var idAgencias = from j in ilha.Agencia select j.IdAgencia;
                    agencia.AddRange(idAgencias);
                }
                var total = listaDeSocio.Where(a => agencia.Contains(a)).Count();
                data.Add(new data(item, total));
            }
        }
    }
}