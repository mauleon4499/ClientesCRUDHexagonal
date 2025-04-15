using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
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
