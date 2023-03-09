using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class LogAtividade : EntidadeBase
    {
        [Key]
        public int IdLogAtividades { get; set; }
        public string Dados { get; set; }
        public string Url { get; set; }
        public string NomeUtilizador { get; set; }
        public string EnderecoIp { get; set; }

         
        public LogAtividade()
        {
        }

        public LogAtividade(string dados, string url, string nomeUtilizador, string enderecoIp)
        {
            Dados = dados;
            Url = url;
            NomeUtilizador = nomeUtilizador;
            EnderecoIp = enderecoIp;
        }

    }
}