using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IDireccionService
    {
        Task<IEnumerable<Direccion>> GetAllAsync();
        Task<Direccion> GetByIdAsync(int id);
        Task CreateAsync(Direccion direccion);
        Task UpdateAsync(Direccion direccion);
        Task DeleteAsync(int id);
    }
}
