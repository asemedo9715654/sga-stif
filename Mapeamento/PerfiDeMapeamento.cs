using AutoMapper;

using sga_stif.Extensao;
using sga_stif.Models;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.Beneficiario;
using sga_stif.ViewModel.Ilha;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.MenuAcao;
using sga_stif.ViewModel.Perfil;
using sga_stif.ViewModel.Socio;
using sga_stif.ViewModel.TipologiaSocio;
using sga_stif.ViewModel.TipoQuota;
using sga_stif.ViewModel.Utilizador;

namespace sga_stif.Mapeamento
{
    public class PerfiDeMapeamento : Profile
    {

        public PerfiDeMapeamento()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Agencia, ListaAgenciaViewModel>()
              .ForMember(dest => dest.TotalDeSocios, opt => opt.MapFrom(src => src.TotalSocios()))
              .ForMember(dest => dest.NomeCidade, opt => opt.MapFrom(src => src.Cidade.Nome))
              .ForMember(dest => dest.NomeInstituicaoFinanceira, opt => opt.MapFrom(src => src.InstituicaoFinanceira.Nome));

            CreateMap<NovaAgenciaViewModel, Agencia>();
            CreateMap<EditaAgenciaViewModel, Agencia>();
            CreateMap<Agencia, EditaAgenciaViewModel>();
            CreateMap<Agencia, InativarAgenciaViewModel>()
              .ForMember(dest => dest.NomeCidade, opt => opt.MapFrom(src => src.Cidade.Nome))
              .ForMember(dest => dest.NomeInstituicaoFinanceira, opt => opt.MapFrom(src => src.InstituicaoFinanceira.Nome));

            CreateMap<Beneficiario, ListaBeneficiarioViewModel>()
              .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.NomeCompleto()))
              .ForMember(dest => dest.GrauDeParentesco, opt => opt.MapFrom(src => src.GrauDeParentesco.PegarDescricao()));


            CreateMap<TipologiaSocio, ListaTipologiaSocioViewModel>()
               .ForMember(dest => dest.TotalDeSocios, opt => opt.MapFrom(src => src.TotalDeSocios()));


            CreateMap<NovoBeneficiarioViewModel, Beneficiario>();

            CreateMap<EditaBeneficiarioViewModel, Beneficiario>();
            CreateMap<Beneficiario, EditaBeneficiarioViewModel>();

            CreateMap<TipoQuota, ListaTipoQuotaViewModel>()
            .ForMember(dest => dest.TotalSocio, opt => opt.MapFrom(src => src.TotalSocio()));


            //perfil
            CreateMap<Perfil, InativarPerfilViewModel>();
            CreateMap<Perfil, ListaPerfilViewModel>()
             .ForMember(dest => dest.TotalUtilizadores, opt => opt.MapFrom(src => src.TotalUtilizadores()));

            CreateMap<Perfil, EditaPerfilViewModel>();
            CreateMap<EditaPerfilViewModel, Perfil>();
            CreateMap<NovoPerfilViewModel, Perfil>();
            CreateMap<Perfil, NovoPerfilViewModel>();

            //instituicao financeira
            CreateMap<InstituicaoFinanceira, ListaInstituicaoFinanceiraViewModel>()
             .ForMember(dest => dest.TotalDeAgencias, opt => opt.MapFrom(src => src.TotalAgencias()))
             .ForMember(dest => dest.TotalDeSocios, opt => opt.MapFrom(src => src.TotalSocios()));

            CreateMap<NovoInstituicaoFinanceiraViewModel, InstituicaoFinanceira>();
            CreateMap<InstituicaoFinanceira, InativarInstituicaoFinanceiraViewModel>();
            CreateMap<EditaInstituicaoFinanceiraViewModel, InstituicaoFinanceira>();
            CreateMap<InstituicaoFinanceira, EditaInstituicaoFinanceiraViewModel>();
            CreateMap<InstituicaoFinanceiraColaboradores, ListaInstituicaoFinanceiraColaboradoresViewModel>();
            CreateMap<InstituicaoFinanceira, DetalhesInstituicaoFinanceiraViewModel>()
            .ForMember(dest => dest.TotalAgencias, opt => opt.MapFrom(src => src.TotalAgencias()))
            .ForMember(dest => dest.ListaInstituicaoFinanceiraColaboradoresViewModel, opt => opt.MapFrom(src => src.InstituicaoFinanceiraColaboradores));

            //utilizador
            CreateMap<NovoInstituicaoFinanceiraColaboradoresViewModel, InstituicaoFinanceiraColaboradores>();

            CreateMap<NovoUtilizadorViewModel, Utilizador>();
            CreateMap<Utilizador, EditaUtilizadorViewModel>();
            CreateMap<EditaUtilizadorViewModel, Utilizador>();
            CreateMap<Utilizador, DetalhesUtilizadorViewModel>()
              .ForMember(dest => dest.NomePerfil, opt => opt.MapFrom(src => src.Perfil.Nome))
            ;
            CreateMap<Utilizador, InativarUtilizadorViewModel>()
              .ForMember(dest => dest.NomePerfil, opt => opt.MapFrom(src => src.Perfil.Nome))
            ;

            CreateMap<Utilizador, NovoUtilizadorViewModel>();
            CreateMap<Utilizador, ListaUtilizadorViewModel>()
             .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.PegarNomeCompleto()))
             .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => src.PegarLinkFoto()))
             .ForMember(dest => dest.NomePerfil, opt => opt.MapFrom(src => src.Perfil.Nome))
            ;

            CreateMap<Utilizador, DadosUtilizadorViewModel>()
                .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.PegarNomeCompleto()))
                .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => src.PegarLinkFoto()))
                .ForMember(dest => dest.NomePerfil, opt => opt.MapFrom(src => src.Perfil.Nome))
                ;

            CreateMap<Menu, ListaMenuViewModel>()
              .ForMember(dest => dest.TipoMenu, opt => opt.MapFrom(src => src.Categoria()));


            CreateMap<MenuAcao, ListaMenuAcaoViewModel>()
            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Menu.Nome + " --- " + src.Acao.Nome));


            CreateMap<PerfilInstituicaoFinanceira, ListaPerfilInstituicaoFinanceiraViewModel>()
            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.InstituicaoFinanceira.Nome));

            //socio
            CreateMap<Socio, NovoSocioViewModel>();
            CreateMap<Socio, ListaSocioViewModel>()
             .ForMember(dest => dest.SiglaInstitucaoFinanceira, opt => opt.MapFrom(src => src.Agencia.InstituicaoFinanceira.SiglaFormatado()))
             .ForMember(dest => dest.NomeAgencia, opt => opt.MapFrom(src => src.Agencia.Nome))
             .ForMember(dest => dest.Sexo, opt => opt.MapFrom(src => src.Sexo.PegarDescricao()))
             .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.NomeCompleto()))
             .ForMember(dest => dest.TotalBeneficiario, opt => opt.MapFrom(src => src.TotalBeneficiario()));
            ;
            CreateMap<NovoSocioViewModel, Socio>();
            CreateMap<EditaSocioViewModel, Socio>();
            CreateMap<Socio, EditaSocioViewModel>();

            CreateMap<Socio, DestalhesSocioViewModel>()
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeFormatado()))
            .ForMember(dest => dest.Apelido, opt => opt.MapFrom(src => src.ApelidoFormatado()))
            .ForMember(dest => dest.HabilitacaoLiteraria, opt => opt.MapFrom(src => src.HabilitacaoLiteraria.PegarDescricao()))
            .ForMember(dest => dest.Sexo, opt => opt.MapFrom(src => src.Sexo.PegarDescricao()))
            .ForMember(dest => dest.EstadoCivil, opt => opt.MapFrom(src => src.EstadoCivil.PegarDescricao()))
            .ForMember(dest => dest.DataEntregaCartao, opt => opt.MapFrom(src => src.DataEntregaCartao == null?"N�o Entregue!": src.DataEntregaCartao.Value.ToString("dd-MM-yyyy")))
            //.ForMember(dest => dest.DataEntregaCartao, opt => opt.MapFrom(src => src.DataEntregaCartao ?? DateTime.MinValue))

            //.ForMember(dest => dest.DerigenteStiff, opt => opt.MapFrom(src => src.DerigenteStiff.PegarDescricao()))
            .ForMember(dest => dest.DerigenteStiff,opt => opt.MapFrom(src => src.DerigenteStiff != null ? src.DerigenteStiff.PegarDescricao() : "Indefinido"))
            .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => src.PegarLinkFotoGrande()))
            .ForMember(dest => dest.ListaBeneficiarioViewModel, opt => opt.MapFrom(src => src.Beneficiario))
            .ForMember(dest => dest.NomeAgencia, opt => opt.MapFrom(src => src.Agencia.NomeFormatado()))
            .ForMember(dest => dest.NomeTipoQuota, opt => opt.MapFrom(src => src.TipoQuota.Descricao))
            .ForMember(dest => dest.NomeTipologia, opt => opt.MapFrom(src => src.TipologiaSocio.Descricao))
            .ForMember(dest => dest.NomeIlha, opt => opt.MapFrom(src => src.Agencia.Cidade.Ilha.NomeFormatado()))
            .ForMember(dest => dest.NomeCidade, opt => opt.MapFrom(src => src.Agencia.Cidade.NomeFormatado()))
            .ForMember(dest => dest.NomeInstituicaoFinanceira, opt => opt.MapFrom(src => src.Agencia.InstituicaoFinanceira.NomeFormatado()))
            .ForMember(dest => dest.IdInstituicaoFinanceira, opt => opt.MapFrom(src => src.Agencia.InstituicaoFinanceira.IdInstituicaoFinanceira))
            ;



            CreateMap<Ilha, ListaIlhaViewModel>()
            .ForMember(dest => dest.NomeFormatado, opt => opt.MapFrom(src => src.NomeFormatado())) // Mapeia o nome formatado
            .ForMember(dest => dest.TotalSocios, opt => opt.MapFrom(src => src.TotalSocios())); // Mapeia o total de s�cios

        }

    }
}