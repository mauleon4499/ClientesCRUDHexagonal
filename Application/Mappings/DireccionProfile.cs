using AppLogic.DTOs;
using AutoMapper;
using Domain.Entities;

namespace AppLogic.Mappings
{
    public class DireccionProfile : Profile
    {
        public DireccionProfile()
        {
            CreateMap<Direccion, DireccionDTO>();
            CreateMap<CrearDireccionDTO, Direccion>();
            CreateMap<UpdateDireccionDTO, Direccion>();
            CreateMap<Direccion, UpdateDireccionDTO>();
        }
    }
}
