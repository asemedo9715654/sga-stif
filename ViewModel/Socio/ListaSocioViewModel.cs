using sga_stif.Models;

namespace sga_stif.ViewModel.Socio
{
    public class ListaSocioViewModel
    {
         public int IdSocio { get; set; }
        public byte[]? Foto { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Nif { get; set; }
        public string CinBi { get; set; }
        public string NumeroPassaporte { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public string NumeroDeTelefone { get; set; }
    }
}