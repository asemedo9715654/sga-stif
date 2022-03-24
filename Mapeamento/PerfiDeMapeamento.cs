using AutoMapper;
using sga_stif.Models;
using sga_stif.ViewModel.Beneficiario;
using sga_stif.ViewModel.Socio;

namespace sga_stif.Mapeamento
{
    public class PerfiDeMapeamento : Profile
    {

        public PerfiDeMapeamento()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Socio, NovoSocioViewModel>();
            CreateMap<List<Socio>, List<ListaSocioViewModel>>();
            CreateMap<NovoSocioViewModel, Socio>();

            CreateMap<Beneficiario, ListaBeneficiarioViewModel>();
            CreateMap<NovoBeneficiarioViewModel,Beneficiario>();

            CreateMap<Socio, DestalhesSocioViewModel>()
            .ForMember(dest =>dest.ListaBeneficiarioViewModel,opt => opt.MapFrom(src => src.Beneficiario))
            .ForMember(dest =>dest.NomeAgencia,opt => opt.MapFrom(src => src.Agencia.Nome))
            .ForMember(dest =>dest.NomeTipoQuota,opt => opt.MapFrom(src => src.TipoQuota.Descricao))
            .ForMember(dest =>dest.NomeTipologia,opt => opt.MapFrom(src => src.TipologiaSocio.Descricao))
            .ForMember(dest =>dest.NomeIlha,opt => opt.MapFrom(src => src.Agencia.Cidade.Ilha.Nome))
            .ForMember(dest =>dest.NomeCidade,opt => opt.MapFrom(src => src.Agencia.Cidade.Nome))
            ;

        }

    }
}