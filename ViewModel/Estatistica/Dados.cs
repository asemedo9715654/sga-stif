using sga_stif.Extensao;
using sga_stif.Models;

namespace sga_stif.ViewModel.Estatistica
{
    public class Dados
    {
        public string name { get; set; }
        public List<int> data { get; set; }

        public Dados()
        {
            
        } 
        
        public Dados(Sexo sexo)
        {
            name = sexo.PegarDescricao();
            data = new List<int>();
        }
    }
}
