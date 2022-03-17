namespace sga_stif.Models
{
    public class EntidadeBase
    {
        public DateTime? DataCriacao { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; } = DateTime.Now;
        public bool Eliminado { get; set; }=false;
    }
    
}