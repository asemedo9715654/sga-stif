using System.ComponentModel.DataAnnotations;
using sga_stif.Models;
namespace sga_stif.ViewModel.InstituicaoFinanceira;


public class EmailViewModel
{
    public int IdInstituicaoFinanceira { get; set; }
    public string Assunto { get; set; }
    public string Sexo { get; set; }
    [Display(Name = "Texto do e-mail")]
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