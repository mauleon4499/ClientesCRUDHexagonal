using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDireccionRepository
    {
        Task<IEnumerable<Direccion>> GetAllAsync();
        Task<Direccion> GetByIdAsync(int id);
        Task AddAsync(Direccion direccion);
        Task UpdateAsync(Direccion direccion);
        Task DeleteAsync(int id);
    }
}
