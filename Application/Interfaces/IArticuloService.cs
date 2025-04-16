using AppLogic.DTOs;
using Domain.Entities;

namespace AppLogic.Interfaces
{
    public interface IArticuloService
    {
        Task<IEnumerable<ArticuloDTO>> GetAllAsync();
        Task<Articulo> GetByIdAsync(int id);
        Task<Articulo> CreateAsync(Articulo articulo);
        Task UpdateAsync(Articulo articulo);
        Task DeleteAsync(int id);

        Task CrearArticuloAsync(CrearArticuloDTO dto);
        Task<List<ArticuloDTO>> ObtenerArticulosAsync();
    }
}
