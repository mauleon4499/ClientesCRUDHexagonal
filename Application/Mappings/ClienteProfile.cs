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
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteDTO>();       //Mapeo de Cliente a ClienteDTO (para devolver al usuario)
            CreateMap<CrearClienteDTO, Cliente>();  //Mapeo de CrearClienteDTO a Cliente (para crear un nuevo cliente)
        }
    }
}
