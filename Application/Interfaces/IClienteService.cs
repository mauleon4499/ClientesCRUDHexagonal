using AppLogic.DTOs;
using Domain.Entities;

namespace AppLogic.Interfaces
{
    public interface IClienteService
    {
        //CLIENTES
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(int id);
        Task<Cliente> CreateAsync(Cliente cliente);
        Task UpdateAsync(Cliente cliente);
        Task DeleteAsync(int id);

        //CLIENTES DTO
        Task CrearClienteAsync(CrearClienteDTO dto);
        Task<List<ClienteDTO>> ObtenerClientesAsync();
    }
}
