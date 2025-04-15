using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces
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
