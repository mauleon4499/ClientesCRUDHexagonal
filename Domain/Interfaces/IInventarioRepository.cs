using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IInventarioRepository
    {
        Task<IEnumerable<Inventario>> GetAllAsync();
        Task<Inventario> GetByIdAsync(int id);
        Task AddAsync(Inventario entity);
        Task UpdateAsync(Inventario entity);
        Task DeleteAsync(int id);
    }
}
