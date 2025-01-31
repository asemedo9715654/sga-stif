using System.ComponentModel.DataAnnotations;
using sga_stif.Models;

namespace sga_stif.ViewModel.Socio
{
  public class EditaSocioViewModel
  {
    [Key]
    public int IdSocio { get; set; }
    [Display(Name = "Fotografia")]
    public string? Image { get; set; }
    public string? Foto { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    [Display(Name = "Número de Identificação Fiscal")]
    public string? Nif { get; set; }
    [Display(Name = "CIN/BI")]
    public string CinBi { get; set; }

    [Display(Name = "Válidade CIN/BI")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? ValidadeCinBi { get; set; }

    [Display(Name = "Número de Passaporte")]
    public string? NumeroPassaporte { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Válidade de passaporte")]
    public DateTime ValidadePassaporte { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataDeNascimento { get; set; }
    public Sexo Sexo { get; set; }
    [Display(Name = "Estado Cívil")]
    public EstadoCivil EstadoCivil { get; set; }

    [Display(Name = "Número de Telefone")]
    public string? NumeroDeTelefone { get; set; }
    [Display(Name = "Número de Telemovel")]
    public string? NumeroDeTelemovel { get; set; }
    [EmailAddress]
    public string Email { get; set; }

     [Display(Name = "Número de Colaborador")]
    public string NumeroColaborador { get; set; }

     [Display(Name = "Número de Socio")]
    public string NumeroDeSocio { get; set; }
    

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Ativação")]
    [Required(ErrorMessage = "A Data de Ativação é necessário")]
    public DateTime? DataAtivacao { get; set; }

   // [Required(ErrorMessage = "Agência de Sócio é necessário")]
    public int IdInstituicaoFinanceira { get; set; }

    [Display(Name = "Agência")]
    public int IdAgencia { get; set; }
    [Display(Name = "Tipológia de Sócio")]
    //  [Required(ErrorMessage = "Tipológia de Sócio é necessário")]
    public int IdTipologiaSocio { get; set; }
    [Display(Name = "Tipo de Quota")]
    // [Required(ErrorMessage = "Tipo quota de Sócio é necessário")]
    public int IdTipoQuota { get; set; }

    [Display(Name = "Habilitação Literária")]
    public HabilitacaoLiteraria HabilitacaoLiteraria { get; set; }

  }
}