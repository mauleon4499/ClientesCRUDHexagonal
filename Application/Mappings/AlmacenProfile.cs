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
    public class AlmacenProfile : Profile
    {
        public AlmacenProfile()
        {
            CreateMap<Almacen, AlmacenDTO>().ReverseMap();
            CreateMap<Almacen, CrearAlmacenDTO>().ReverseMap();
            CreateMap<Almacen, UpdateAlmacenDTO>().ReverseMap();
        }
    }
}
