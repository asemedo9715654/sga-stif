using System.ComponentModel.DataAnnotations;
using sga_stif.Models;
namespace sga_stif.ViewModel.Ilha;

public class EmailIlhaViewModel
{
    public int IdIlha { get; set; }
    public string Assunto { get; set; }
    public string Sexo { get; set; }
    [Display(Name = "Texto do e-mail")]
    public string CorpoDoEmail { get; set; }
	[Display(Name = "Instituição Financeira")]
	public int IdInstituicaoFinanceira { get; set; }

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
    
    public List<sga_stif.Models.Socio> FiltrarSocioPorInstituicaoFinanceira(List<sga_stif.Models.Socio> socios)
    {
        if (this.IdInstituicaoFinanceira != -1)
            socios = socios.Where(d => d.Agencia.IdInstituicaoFinanceira == this.IdInstituicaoFinanceira).ToList();
        return socios;
    }


}