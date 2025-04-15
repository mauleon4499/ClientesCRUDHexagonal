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
