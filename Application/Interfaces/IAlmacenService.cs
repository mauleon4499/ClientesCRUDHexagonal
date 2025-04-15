using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAlmacenService
    {
        Task<IEnumerable<AlmacenDTO>> GetAllAsync();
        Task<Almacen> GetByIdAsync(int id);
        Task<Almacen> CreateAsync(Almacen almacen);
        Task UpdateAsync(Almacen almacen);
        Task DeleteAsync(int id);

        Task CrearAlmacenAsync(CrearAlmacenDTO dto);
        Task<List<AlmacenDTO>> ObtenerAlmacenesAsync();
    }
}
