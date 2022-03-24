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
            CreateMap<Socio, SocioViewModel>();
            CreateMap<SocioViewModel, Socio>();

            CreateMap<Beneficiario, ListaBeneficiarioViewModel>();
            CreateMap<NovoBeneficiarioViewModel,Beneficiario>();

            CreateMap<Socio, DestalhesSocioViewModel>().ForMember(dest =>
            dest.ListaBeneficiarioViewModel,
            opt => opt.MapFrom(src => src.Beneficiario));

        }

    }
}