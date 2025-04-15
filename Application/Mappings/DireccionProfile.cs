using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
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
