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
       
    }
}