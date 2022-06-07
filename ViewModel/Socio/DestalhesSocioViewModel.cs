using System.ComponentModel.DataAnnotations;
using sga_stif.ViewModel.Beneficiario;
using sga_stif.Models;
using sga_stif.Models.ResultadoStoredProcedure;

namespace sga_stif.ViewModel.Socio
{
  public class DestalhesSocioViewModel
  {
    [Key]
    public int IdSocio { get; set; }
     public string NumeroDeSocio { get; set; }
     public string NumeroColaborador { get; set; }
    [Display(Name = "Fotografia")]
    public string Foto { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    [Display(Name = "Número de Identificação Fiscal")]
    public string Nif { get; set; }
    [Display(Name = "CIN BI")]
    public string CinBi { get; set; }
    [Display(Name = "Número de Passaporte")]
    public string NumeroPassaporte { get; set; }
    [Display(Name = "Agência")]
    public int IdAgencia { get; set; }
    [Display(Name = "Tipológia de Socio")]
    public int IdTipologiaSocio { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Ativação")]
    public DateTime? DataAtivacao { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Nascimento")]
     public DateTime DataDeNascimento { get; set; }

    public string Sexo { get; set; }
    public string EstadoCivil { get; set; }

    public string NumeroDeTelefone { get; set; }
    public string? NumeroDeTelemovel { get; set; }

     [Display(Name = "E-mail")]
    public string Email { get; set; }


    [Display(Name = "Tipo de Quota")]
    public int IdTipoQuota { get; set; }
    public string NomeInstituicaoFinanceira { get; set; }
    public int IdInstituicaoFinanceira { get; set; }
    public string NomeAgencia { get; set; }
    public string NomeIlha { get; set; }
    public string NomeCidade { get; set; }
    public string NomeTipologia { get; set; }
    public string NomeTipoQuota { get; set; }



    public List<ListaBeneficiarioViewModel> ListaBeneficiarioViewModel { get; set; }
    public List<ContaCorrenteSocioResultado> ListaContaCorrenteSocioResultado_Pagas { get; set; } = new List<ContaCorrenteSocioResultado>();
    public List<ContaCorrenteSocioResultado> ListaContaCorrenteSocioResultado_Vencidas { get; set; } = new List<ContaCorrenteSocioResultado>();
    public List<ContaCorrenteSocioResultado> ListaContaCorrenteSocioResultado_PorPagar { get; set; } = new List<ContaCorrenteSocioResultado>();
    
    public List<ContaHistorialSocioResultado> ListaContaHistorialSocioResultadoHistorial { get; set; } = new List<ContaHistorialSocioResultado>();


  }
}