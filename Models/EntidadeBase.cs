namespace sga_stif.Models
{
    public class EntidadeBase
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Eliminado { get; set; }=false;
    }
    
}