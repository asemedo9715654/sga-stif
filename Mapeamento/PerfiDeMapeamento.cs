using AutoMapper;
using sga_stif.Models;
using sga_stif.ViewModel;
using sga_stif.ViewModel.Agencia;
using sga_stif.ViewModel.Beneficiario;
using sga_stif.ViewModel.InstituicaoFinanceira;
using sga_stif.ViewModel.MenuAcao;
using sga_stif.ViewModel.Perfil;
using sga_stif.ViewModel.Socio;
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
              .ForMember(dest =>dest.NomeCidade,opt => opt.MapFrom(src => src.Cidade.Nome))
              .ForMember(dest =>dest.NomeInstituicaoFinanceira,opt => opt.MapFrom(src => src.InstituicaoFinanceira.Nome));

            CreateMap<Socio, NovoSocioViewModel>();
            CreateMap<Socio, ListaSocioViewModel>();
            CreateMap<NovoSocioViewModel, Socio>();

            CreateMap<Beneficiario, ListaBeneficiarioViewModel>();


            CreateMap<NovoBeneficiarioViewModel,Beneficiario>();

            CreateMap<EditaBeneficiarioViewModel,Beneficiario>();
            CreateMap<Beneficiario,EditaBeneficiarioViewModel>();

            CreateMap<TipoQuota,ListaTipoQuotaViewModel>();

            CreateMap<Perfil,ListaPerfilViewModel>();
            CreateMap<Perfil,EditaPerfilViewModel>();
            CreateMap<EditaPerfilViewModel,Perfil>();

            CreateMap<InstituicaoFinanceira,ListaInstituicaoFinanceiraViewModel>();


            CreateMap<EditaUtilizadorViewModel,Utilizador>();
            CreateMap<NovoUtilizadorViewModel,Utilizador>();
            CreateMap<Utilizador,EditaUtilizadorViewModel>();
            CreateMap<Utilizador,NovoUtilizadorViewModel>();

            CreateMap<Menu,ListaMenuViewModel>()
              .ForMember(dest =>dest.TipoMenu,opt => opt.MapFrom(src => src.Categoria()));


            CreateMap< MenuAcao,ListaMenuAcaoViewModel>()
            .ForMember(dest =>dest.Descricao,opt => opt.MapFrom(src => src.Menu.Nome +" --- "+src.Acao.Nome));


            CreateMap<Utilizador,ListaUtilizadorViewModel>()
             .ForMember(dest =>dest.NomePerfil,opt => opt.MapFrom(src => src.Perfil.Descricao))
            ;

            CreateMap<Socio, DestalhesSocioViewModel>()
            .ForMember(dest =>dest.ListaBeneficiarioViewModel,opt => opt.MapFrom(src => src.Beneficiario))
            .ForMember(dest =>dest.NomeAgencia,opt => opt.MapFrom(src => src.Agencia.Nome))
            .ForMember(dest =>dest.NomeTipoQuota,opt => opt.MapFrom(src => src.TipoQuota.Descricao))
            .ForMember(dest =>dest.NomeTipologia,opt => opt.MapFrom(src => src.TipologiaSocio.Descricao+" ( "+src.TipologiaSocio.Montante+" )"))
            .ForMember(dest =>dest.NomeIlha,opt => opt.MapFrom(src => src.Agencia.Cidade.Ilha.Nome))
            .ForMember(dest =>dest.NomeCidade,opt => opt.MapFrom(src => src.Agencia.Cidade.Nome))
            .ForMember(dest =>dest.NomeInstituicaoFinanceira,opt => opt.MapFrom(src => src.Agencia.InstituicaoFinanceira.Nome))
            ;

        }

    }
}