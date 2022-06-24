using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using sga_stif.Models;
using sga_stif.ViewModel.Vlidacao;

namespace sga_stif.ViewModel.Socio
{
  public class NovoSocioViewModel
  {
    [Key]
    public int IdSocio { get; set; }
    // [Display(Name = "Fotografia")]
    // public byte[]? Foto { get; set; }
    [Required(ErrorMessage = "O Nome é necessario")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Apelido é necessário")]
    public string Apelido { get; set; }

    [Display(Name = "Número de Identificação Fiscal")]
    // [Required(ErrorMessage = "O NIF é necessário")]
    [StringLength(9, MinimumLength = 9)]
    public string? Nif { get; set; }
    [Display(Name = "CIN/BI")]
    [Remote(action: "VereficaCniBi", controller: "Socio")]
    [Required(ErrorMessage = "O CNI/BI é necessário")]
    public string CinBi { get; set; }

    [Display(Name = "Válidade CIN/BI")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "A Validade é necessário")]
    public DateTime ValidadeCinBi { get; set; }

    [Display(Name = "Número de Passaporte")]
    [Remote(action: "VereficaNumeroPassaporte", controller: "Socio")]
    public string? NumeroPassaporte { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Válidade de passaporte")]
    public DateTime? ValidadePassaporte { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "A Data de Nascimento é necessário")]
    // [ValidacaoRangeData(ErrorMessage="Idade fora de parametro")]
    public DateTime DataDeNascimento { get; set; }

    [Required(ErrorMessage = "O Sexo é necessário")]
    public Sexo Sexo { get; set; }

    [Required(ErrorMessage = "O Estado Civíl é necessario")]
    [Display(Name = "Estádo Cívil")]
    public EstadoCivil EstadoCivil { get; set; }

    [Display(Name = "Número de Telefone")]
    public string? NumeroDeTelefone { get; set; }
    [Display(Name = "Número de Telemovel")]
    [Required(ErrorMessage = "O Número de Telefone é necessário")]
    public string? NumeroDeTelemovel { get; set; }

    [EmailAddress]
    [Remote(action: "VereficaEmail", controller: "Socio")]
    [Required(ErrorMessage = "O E-Mail é necessario")]
    public string Email { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Data de Ativação")]
    [Required(ErrorMessage = "A Data de Ativação é necessário")]
    public string? DataAtivacao { get; set; }

    // [Required(ErrorMessage = "Agência de Sócio é necessário")]
    public int IdInstituicaoFinanceira { get; set; }

    [Display(Name = "Agência")]
    public int IdAgencia { get; set; }
    [Display(Name = "Tipológia de Sócio")]
    [Required(ErrorMessage = "Tipológia de Sócio é necessário")]
    public int IdTipologiaSocio { get; set; }
    [Display(Name = "Tipo de Quota")]
    [Required(ErrorMessage = "Tipo quota de Sócio é necessário")]
    public int IdTipoQuota { get; set; }

    [Display(Name = "Número De Sócio")]
      public string NumeroDeSocio { get; set; }
     [Display(Name = "Número De Colaborador")]
     public string NumeroColaborador { get; set; }
    public HabilitacaoLiteraria HabilitacaoLiteraria { get; set; }

  }
}