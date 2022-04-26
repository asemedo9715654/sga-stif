using AutoMapper;
using sga_stif.Models;
using sga_stif.ViewModel;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.Beneficiario;
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



            CreateMap<Beneficiario, ListaBeneficiarioViewModel>();


            CreateMap<TipologiaSocio, ListaTipologiaSocioViewModel>()
               .ForMember(dest => dest.TotalDeSocios, opt => opt.MapFrom(src => src.TotalDeSocios()));


            CreateMap<NovoBeneficiarioViewModel, Beneficiario>();

            CreateMap<EditaBeneficiarioViewModel, Beneficiario>();
            CreateMap<Beneficiario, EditaBeneficiarioViewModel>();

            CreateMap<TipoQuota, ListaTipoQuotaViewModel>()
            .ForMember(dest => dest.TotalSocio, opt => opt.MapFrom(src => src.TotalSocio()));


            //perfil
            CreateMap<Perfil, ListaPerfilViewModel>()
             .ForMember(dest => dest.TotalUtilizadores, opt => opt.MapFrom(src => src.TotalUtilizadores()));

            CreateMap<Perfil, EditaPerfilViewModel>();
            CreateMap<EditaPerfilViewModel, Perfil>();
            CreateMap<NovoPerfilViewModel, Perfil>();
            CreateMap<Perfil,NovoPerfilViewModel >();

            //instituicao financeira
            CreateMap<InstituicaoFinanceira, ListaInstituicaoFinanceiraViewModel>()
             .ForMember(dest => dest.TotalDeAgencias, opt => opt.MapFrom(src => src.TotalAgencias()))
             .ForMember(dest => dest.TotalDeSocios, opt => opt.MapFrom(src => src.TotalSocios()));

            CreateMap<NovoInstituicaoFinanceiraViewModel, InstituicaoFinanceira>();
            CreateMap<EditaInstituicaoFinanceiraViewModel, InstituicaoFinanceira>();
            CreateMap<InstituicaoFinanceira, EditaInstituicaoFinanceiraViewModel>();
            CreateMap<InstituicaoFinanceiraColaboradores, ListaInstituicaoFinanceiraColaboradoresViewModel>();
            CreateMap<InstituicaoFinanceira, DetalhesInstituicaoFinanceiraViewModel>() 
            .ForMember(dest => dest.ListaInstituicaoFinanceiraColaboradoresViewModel, opt => opt.MapFrom(src => src.InstituicaoFinanceiraColaboradores));

            //utilizador
            CreateMap<NovoInstituicaoFinanceiraColaboradoresViewModel, InstituicaoFinanceiraColaboradores>();

            CreateMap<NovoUtilizadorViewModel, Utilizador>();
            CreateMap<Utilizador, EditaUtilizadorViewModel>();
            CreateMap<Utilizador, DetalhesUtilizadorViewModel>()
              .ForMember(dest => dest.NomePerfil, opt => opt.MapFrom(src => src.Perfil.Nome))
            ;

            CreateMap<Utilizador, NovoUtilizadorViewModel>();
            CreateMap<Utilizador, ListaUtilizadorViewModel>()
             .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => src.PegarLinkFoto()))
             .ForMember(dest => dest.NomePerfil, opt => opt.MapFrom(src => src.Perfil.Nome))
            ;

            CreateMap<Menu, ListaMenuViewModel>()
              .ForMember(dest => dest.TipoMenu, opt => opt.MapFrom(src => src.Categoria()));


            CreateMap<MenuAcao, ListaMenuAcaoViewModel>()
            .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Menu.Nome + " --- " + src.Acao.Nome));

            //socio
            CreateMap<Socio, NovoSocioViewModel>();
            CreateMap<Socio, ListaSocioViewModel>()
             .ForMember(dest => dest.NomeCompleto, opt => opt.MapFrom(src => src.NomeCompleto()))
             .ForMember(dest => dest.TotalBeneficiario, opt => opt.MapFrom(src => src.TotalBeneficiario()));
            ;
            CreateMap<NovoSocioViewModel, Socio>();
            CreateMap<EditaSocioViewModel, Socio>();
            CreateMap<Socio,EditaSocioViewModel >();

            CreateMap<Socio, DestalhesSocioViewModel>()
            .ForMember(dest => dest.Foto, opt => opt.MapFrom(src => src.PegarLinkFotoGrande()))
            .ForMember(dest => dest.ListaBeneficiarioViewModel, opt => opt.MapFrom(src => src.Beneficiario))
            .ForMember(dest => dest.NomeAgencia, opt => opt.MapFrom(src => src.Agencia.Nome))
            .ForMember(dest => dest.NomeTipoQuota, opt => opt.MapFrom(src => src.TipoQuota.Descricao))
            .ForMember(dest => dest.NomeTipologia, opt => opt.MapFrom(src => src.TipologiaSocio.Descricao ))
            .ForMember(dest => dest.NomeIlha, opt => opt.MapFrom(src => src.Agencia.Cidade.Ilha.Nome))
            .ForMember(dest => dest.NomeCidade, opt => opt.MapFrom(src => src.Agencia.Cidade.Nome))
            .ForMember(dest => dest.NomeInstituicaoFinanceira, opt => opt.MapFrom(src => src.Agencia.InstituicaoFinanceira.Nome))
            ;

        }

    }
}