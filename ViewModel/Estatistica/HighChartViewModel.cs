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
    }
}