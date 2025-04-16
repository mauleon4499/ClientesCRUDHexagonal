using AppLogic.DTOs;
using Domain.Entities;

namespace AppLogic.Interfaces
{
    public interface IUbicacionService
    {
        Task<IEnumerable<UbicacionDTO>> GetAllAsync();
        Task<Ubicacion> GetByIdAsync(int id);
        Task<Ubicacion> CreateAsync(Ubicacion  ubicacion);
        Task UpdateAsync(Ubicacion ubicacion);
        Task DeleteAsync(int id);

        Task CrearUbicacionAsync(CrearUbicacionDTO dto);
        Task<List<UbicacionDTO>> ObtenerUbicacionesAsync();
    }
}
