using AutoMapper;
using sga_stif.Models;
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

        }


    }
}