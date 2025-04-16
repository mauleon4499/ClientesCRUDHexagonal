using AppLogic.DTOs;
using AutoMapper;
using Domain.Entities;

namespace AppLogic.Mappings
{
    public class ArticuloProfile : Profile
    {
        public ArticuloProfile()
        {
            CreateMap<Articulo, ArticuloDTO>().ReverseMap();
            CreateMap<Articulo, CrearArticuloDTO>().ReverseMap();
            CreateMap<Articulo, UpdateArticuloDTO>().ReverseMap();
        }
    }
}
