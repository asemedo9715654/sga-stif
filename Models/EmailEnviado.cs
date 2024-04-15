using sga_stif.ViewModel.InstituicaoFinanceira;
using System.ComponentModel.DataAnnotations;

namespace sga_stif.Models
{
    public class EmailEnviado : EntidadeBase
    {
        [Key]
        public int IdEmailEnviado { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string? NumeroSocio { get; set; }
        public string? Obs { get; set; } = null;
        public string Corpo { get; set; }
        public string Assunto { get; set; }
        public bool JaFoiEnviado { get; set; } = false;


        public EmailEnviado()
        {

        }

        public EmailEnviado(Socio soc, EmailViewModel emailViewModel)
        {
            Obs = null;
            Apelido = soc.Apelido;
            Nome = soc.Nome;
            NumeroSocio = soc.NumeroDeSocio;
            Assunto = emailViewModel.Assunto;
            Email = soc.Email;
            Corpo = emailViewModel.CorpoDoEmail;
            JaFoiEnviado = false;
            Eliminado = false;
            DataAtualizacao = DateTime.Now;
            DataCriacao = DateTime.Now;
        }
        
        public EmailEnviado(Socio soc, EmailTodosViewModel emailViewModel)
        {
            Obs = null;
            Apelido = soc.Apelido;
            Nome = soc.Nome;
            NumeroSocio = soc.NumeroDeSocio;
            Assunto = emailViewModel.Assunto;
            Email = soc.Email;
            Corpo = emailViewModel.CorpoDoEmail;
            JaFoiEnviado = false;
            Eliminado = false;
            DataAtualizacao = DateTime.Now;
            DataCriacao = DateTime.Now;
        }
    }
}
