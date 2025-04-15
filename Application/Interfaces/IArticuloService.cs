using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces
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
