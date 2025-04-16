using AppLogic.DTOs;
using Domain.Entities;

namespace AppLogic.Interfaces
{
    public interface IInventarioService
    {
        Task<IEnumerable<InventarioDTO>> GetAllAsync();
        Task<Inventario> GetByIdAsync(int id);
        Task<Inventario> CreateAsync(Inventario inventario);
        Task UpdateAsync(Inventario inventario);
        Task DeleteAsync(int id);

        Task CrearInventarioAsync(CrearInventarioDTO dto);
        Task<List<InventarioDTO>> ObtenerInventariosAsync();
    }
}
