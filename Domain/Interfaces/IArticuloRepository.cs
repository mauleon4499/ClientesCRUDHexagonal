using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IArticuloRepository
    {
        Task<IEnumerable<Articulo>> GetAllAsync();
        Task<Articulo> GetByIdAsync(int id);
        Task AddAsync(Articulo entity);
        Task UpdateAsync(Articulo entity);
        Task DeleteAsync(int id);
    }
}
