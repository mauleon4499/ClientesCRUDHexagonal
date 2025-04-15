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
