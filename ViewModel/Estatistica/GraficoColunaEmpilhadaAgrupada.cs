using sga_stif.Models;
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


        public void AdicionarCategorias(List<int> listaDeIdades)
        {
            var anterio = 0;
            foreach (var item in listaDeIdades)
            {
                if (item == 25)
                    categorias.Add($"< {item}");
                else if (item == 60)
                    categorias.Add($"{item} < ");
                else
                    categorias.Add($"[{anterio} : {item}]");

                anterio = item + 1;
            }
        }

        public void PreencherDados(List<int> listaDeIdades, List<Sexo> sexos,List<Models.Socio> listaDeSocios)
        {
            var anterio = 0;
            foreach (var sexo in sexos)
            {
                var dados = new Dados(sexo);

                foreach (var idade in listaDeIdades)
                {
                    var total = 0;
                    if (idade == 60)
                        total = listaDeSocios.Where(a => a.PegarIdade() > idade && a.Sexo == sexo).Count();
                    else
                        total = listaDeSocios.Where(a => a.PegarIdade() >= anterio && a.PegarIdade() <= idade && a.Sexo == sexo).Count();

                    anterio = idade + 1;

                    if (sexo == Sexo.Feminino)
                        total *= -1;

                    dados.data.Add(total);
                }
                this.dados.Add(dados);
            }
        }

    } 
}