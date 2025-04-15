using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUbicacionRepository
    {
        Task<IEnumerable<Ubicacion>> GetAllAsync();
        Task<Ubicacion> GetByIdAsync(int id);
        Task AddAsync(Ubicacion entity);
        Task UpdateAsync(Ubicacion entity);
        Task DeleteAsync(int id);
    }
}
