using AppLogic.DTOs;
using AutoMapper;
using Domain.Entities;

namespace AppLogic.Mappings
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CrearClienteDTO, Cliente>();  //Mapeo de CrearClienteDTO a Cliente (para crear un nuevo cliente)
            CreateMap<UpdateClienteDTO, Cliente>();
            CreateMap<Cliente, ClienteDTO>();       
            CreateMap<Cliente, ObtenerClienteDTO>()
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion)); //Mapeo de Cliente a ClienteDTO (para devolver al usuario)
        }
    }
}
