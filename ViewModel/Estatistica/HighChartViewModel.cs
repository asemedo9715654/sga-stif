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

    public class data
    {
        public string name { get; set; }
        public decimal y { get; set; }
        public bool sliced { get; set; }
        public bool selected { get; set; }
    }
}