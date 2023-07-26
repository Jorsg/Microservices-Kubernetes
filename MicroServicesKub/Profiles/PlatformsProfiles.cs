using AutoMapper;
using MicroServicesKub.Dtos;
using MicroServicesKub.Models;

namespace MicroServicesKub.Profiles
{
    public class PlatformsProfiles : Profile
    {
        public PlatformsProfiles()
        {
            //Fuente -> Conversor Mapping
            CreateMap<Pasajero, PasajeroReadDto>();
            CreateMap<PasajeroCreateDto, Pasajero>();
            CreateMap<PasajeroReadDto, PasajeroPublishedDto>();
            
        }
    }
}
