using AutoMapper;
using sga_stif.Models;
using sga_stif.ViewModel;
using sga_stif.ViewModel.Beneficiario;
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
            CreateMap<Socio, NovoSocioViewModel>();
            CreateMap<Socio, ListaSocioViewModel>();
            CreateMap<NovoSocioViewModel, Socio>();

            CreateMap<Beneficiario, ListaBeneficiarioViewModel>();
            CreateMap<NovoBeneficiarioViewModel,Beneficiario>();

            CreateMap<TipoQuota,ListaTipoQuotaViewModel>();

            CreateMap<Perfil,ListaPerfilViewModel>();

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
            ;

        }

    }
}