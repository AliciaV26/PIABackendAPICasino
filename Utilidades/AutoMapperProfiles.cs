using WebAPICasino.Entidades;
using AutoMapper;
using WebAPICasino.DTOs;

namespace WebAPICasino.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Cliente, GetClienteDTO>();
            CreateMap<CreacionRifaDTO, Rifa>();
            CreateMap<RifaDTO, Rifa>();
            CreateMap<Rifa, GetRifaDTO>();
            CreateMap<Rifa,LoteriaDTO>();
            CreateMap<RifaDTO, Rifa>().ReverseMap(); //PATCH
            CreateMap<GanadoresDTO, Rifa>(); //GANADORES DE LA RIFA

        }
        
    }
}
