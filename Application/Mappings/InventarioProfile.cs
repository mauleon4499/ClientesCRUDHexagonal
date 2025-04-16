using AppLogic.DTOs;
using AutoMapper;
using Domain.Entities;

namespace AppLogic.Mappings
{
    public class InventarioProfile : Profile
    {
        public InventarioProfile()
        {
            CreateMap<Inventario, InventarioDTO>().ReverseMap();
            CreateMap<Inventario, CrearInventarioDTO>().ReverseMap();
            CreateMap<Inventario, UpdateInventarioDTO>().ReverseMap();
        }
    }
}
