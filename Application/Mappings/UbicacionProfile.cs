using AppLogic.DTOs;
using AutoMapper;
using Domain.Entities;

namespace AppLogic.Mappings
{
    public class UbicacionProfile : Profile
    {
        public UbicacionProfile()
        {
            CreateMap<Ubicacion, UbicacionDTO>().ReverseMap();
            CreateMap<Ubicacion, CrearUbicacionDTO>().ReverseMap();
            CreateMap<Ubicacion, UpdateUbicacionDTO>().ReverseMap();
        }

    }
}
