using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Mappings;
using Domain.Entities;

namespace Application.Interfaces
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
