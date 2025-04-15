using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAlmacenRepository
    {
        Task<IEnumerable<Almacen>> GetAllAsync();
        Task<Almacen> GetByIdAsync(int id);
        Task AddAsync(Almacen entity);
        Task UpdateAsync(Almacen entity);
        Task DeleteAsync(int id);
    }
}
