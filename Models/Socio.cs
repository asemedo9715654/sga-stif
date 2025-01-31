using Org.BouncyCastle.Asn1.Ocsp;
using sga_stif.Extensao;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace sga_stif.Models
{
    public class Socio : EntidadeBase
    {
        [Key]
        public int IdSocio { get; set; }
        public string NumeroDeSocio { get; set; }
        public string? Foto { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string? Nif { get; set; }
        public string CinBi { get; set; }
        public DateTime ValidadeCinBi { get; set; }
        public string? NumeroPassaporte { get; set; }
        public DateTime? ValidadePassaporte { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string? NumeroDeTelefone { get; set; }
        public string? NumeroDeTelemovel { get; set; }
        public string Email { get; set; }

        public DateTime? DataInicio { get; set; }
        public DateTime? DataAtivacao { get; set; } = DateTime.Now.Date;
        public string NumeroColaborador { get; set; }
        public EstadoDeSocio EstadoSocio { get; set; }
        public HabilitacaoLiteraria HabilitacaoLiteraria { get; set; }
        public DateTime? DataEntregaCartao { get; set; }
        public DerigenteStiff? DerigenteStiff { get; set; }

        //chaves estrangeiras

        [ForeignKey("Agencia")]
        public int IdAgencia { get; set; }
        [ForeignKey("TipologiaSocio")]
        public int IdTipologiaSocio { get; set; }
        [ForeignKey("TipoQuota")]
        public int IdTipoQuota { get; set; }


        //propriedades de navegação
        public virtual Agencia Agencia { get; set; }
        public virtual TipologiaSocio TipologiaSocio { get; set; }
        public virtual TipoQuota TipoQuota { get; set; }
        public virtual ICollection<JoiaSocio> JoiaSocio { get; set; }
        public virtual ICollection<QuotaSocio> QuotaSocio { get; set; }
        public virtual ICollection<Beneficiario> Beneficiario { get; set; }

        public Socio()
        {
            JoiaSocio = new HashSet<JoiaSocio>();
            QuotaSocio = new HashSet<QuotaSocio>();
            Beneficiario = new HashSet<Beneficiario>();
        }

        public void PrepararSocioSocio(Socio socio)
        {
            this.NumeroColaborador = socio.NumeroColaborador;
            this.NumeroDeSocio = socio.NumeroDeSocio;
        }

        public int TotalBeneficiario()
        {
            return Beneficiario.Count();
        }

        public string NomeCompleto()
        {
            var nomeCompleto = "";
            var nomeCopletoSemTratamento = this.Nome + " " + this.Apelido;
            nomeCopletoSemTratamento = Regex.Replace(nomeCopletoSemTratamento, @"\s+", " ");
            nomeCopletoSemTratamento = nomeCopletoSemTratamento.Trim();
            var palavras = nomeCopletoSemTratamento.Split(' ');

            foreach (var palavra in palavras)
                nomeCompleto = nomeCompleto + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();

            return nomeCompleto;

        }

        public string NomeFormatado()
        {
            var nomeCompleto = "";
            var nomeCopletoSemTratamento = this.Nome;
            nomeCopletoSemTratamento = Regex.Replace(nomeCopletoSemTratamento, @"\s+", " ");
            nomeCopletoSemTratamento = nomeCopletoSemTratamento.Trim();
            var palavras = nomeCopletoSemTratamento.Split(' ');

            foreach (var palavra in palavras)
                nomeCompleto = nomeCompleto + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();

            return nomeCompleto;

        }

        public string ApelidoFormatado()
        {
            var nomeCompleto = "";
            var nomeCopletoSemTratamento = this.Apelido;
            nomeCopletoSemTratamento = Regex.Replace(nomeCopletoSemTratamento, @"\s+", " ");
            nomeCopletoSemTratamento = nomeCopletoSemTratamento.Trim();
            var palavras = nomeCopletoSemTratamento.Split(' ');

            foreach (var palavra in palavras)
                nomeCompleto = nomeCompleto + " " + char.ToUpper(palavra[0]) + palavra.Substring(1).ToLower();

            return nomeCompleto;

        }

        public string PegarDDescricaoEstadoCivil()
        {
            return EstadoCivil.PegarDescricao();
        }


        public void GerarNumeroSocio()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            this.NumeroDeSocio = new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public int PegarIdade()
        {
            var hoje = DateTime.Now;
            return hoje.Year - this.DataDeNascimento.Year;
        }

        public void TransformacaoSocio()
        {
            this.Nome = this.Nome.ToUpper();
            this.Apelido = this.Apelido.ToUpper();
        }


        public string PegarLinkFotoGrande()
        {
            if (Foto != null)
                return Foto;
            return "../../dist/img/default-150x150.png"; 
        }

    }

    public enum Sexo
    {
        [Description("Feminino")]
        Feminino,
        [Description("Masculino")]
        Masculino
    }

    public enum EstadoDeSocio
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Inativo")]
        Inativo = 0
    }

    public enum EstadoCivil
    {
        [Description("Solteiro(a)")]
        Solteiro,
        [Description("Viuvo(a)")]
        Viuvo,
        [Description("Casado(a)")]
        Casado,
        [Description("Divorciado(a)")]
        Divorciado,
        [Description("Separação Judicial")]
        SeparacaoJudicial,

    }

    public enum HabilitacaoLiteraria
    {
        [Description("Sem Habilitaçao Literária")]
        SemAbilitacaoLiteraria,
        [Description("Ensino Básico")]
        EnsinoBasico,
        [Description("Ensino Secundário")]
        EnsinoSecundario,
        [Description("Bacharelato")]
        Bacharelato,
        [Description("Licenciado")]
        Licenciado,
        [Description("Pos-Graduado")]
        PosGraduacao,
        [Description("Mestraddo")]
        Mestrado,
        [Description("Doutorado")]
        Doutorado

    }

    public enum DerigenteStiff
    {
        // Centrais
        [Description("Assembleia Geral")]
        Centrais_AssembleiaGeral,

        [Description("Conselho Geral")]
        Centrais_ConselhoGeral,

        [Description("Mesa AG/CG")]
        Centrais_MesaAG_CG,

        [Description("Direção")]
        Centrais_Direcao,

        [Description("Conselho Fiscal")]
        Centrais_ConselhoFiscal,

        [Description("Conselho de Disciplina")]
        Centrais_ConselhoDisciplina,

        // Regionais - Norte
        [Description("Direção Regional Norte")]
        Regionais_DirecaoRegionalNorte,

        [Description("Mesa de Assembleia Regional Norte")]
        Regionais_MesaAssembleiaRegionalNorte,

        // Regionais - Sul
        [Description("Direção Regional Sul")]
        Regionais_DirecaoRegionalSul,

        [Description("Mesa de Assembleia Regional Sul")]
        Regionais_MesaAssembleiaRegionalSul


    }
}