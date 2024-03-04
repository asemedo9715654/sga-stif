using System.ComponentModel.DataAnnotations;

namespace sga_stif.ViewModel.InstituicaoFinanceira
{
    public class EmailTodosViewModel
    {
        public string Assunto { get; set; }
        [Display(Name = "Texto do e-mail")]
        public string Sexo { get; set; }
        public string CorpoDoEmail { get; set; }

        public List<sga_stif.Models.Socio> FiltrarSocio(List<sga_stif.Models.Socio> socios, string sexo)
        {
            if (sexo == "Feminino")
            {
                socios = socios.Where(d => d.Sexo == Models.Sexo.Feminino).ToList();
            }
            else if (sexo == "Masculino")
            {
                socios = socios.Where(d => d.Sexo == Models.Sexo.Masculino).ToList();
            }
            return socios;
        }
    }
}
