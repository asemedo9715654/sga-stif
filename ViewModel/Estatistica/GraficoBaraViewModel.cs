using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.Estatistica
{
   public class GraficoBara
    {
        public string[] labels { get; set; }
        public Dataset[] datasets { get; set; }
    }

    public class Dataset
    {
        public bool fill { get; set; } = true;
        public string label { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public int borderWidth { get; set; }
        public decimal[] data { get; set; }
    }
}