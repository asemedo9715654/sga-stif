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

    public class data
    {
        public string name { get; set; }
        public decimal y { get; set; }
        public bool sliced { get; set; }
        public bool selected { get; set; }

        public data()
        {

        }

        public data(Models.TipoQuota tipoQuota, int total)
        {
            selected = tipoQuota.Descricao == "Mensal" ? true : false;
            sliced = tipoQuota.Descricao == "Mensal" ? true : false;
            name = tipoQuota.Descricao;
            y = total;
        }
        public data(Sexo sexo, int total)
        {
            selected = sexo == Sexo.Masculino ? true : false;
            sliced = sexo == Sexo.Masculino ? true : false;
            name = sexo.GetDescription();
            y = total;
        }

        public data(EstadoCivil estadoCivil, int total)
        {
            selected = estadoCivil == EstadoCivil.Casado ? true : false;
            sliced = estadoCivil == EstadoCivil.Casado ? true : false;
            name = estadoCivil.GetDescription();
            y = total;
        }

        public data(Ilha item, int total)
        {
            selected = item.Nome == "Santiago" ? true : false;
            sliced = item.Nome == "Santiago" ? true : false;
            name = item.Nome;
            y = total;
        }
    }
}