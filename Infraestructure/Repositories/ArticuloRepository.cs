using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class ArticuloRepository : IArticuloRepository
    {
        private readonly AppDbContext _context;

        public ArticuloRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Articulo>> GetAllAsync()
        {
            return await _context.Articulos.ToListAsync();
        }

        public async Task<Articulo> GetByIdAsync(int id)
        {
            return await _context.Articulos.FindAsync(id);
        }

        public async Task AddAsync(Articulo entity)
        {
            _context.Articulos.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Articulo entity)
        {
            _context.Articulos.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Articulos.FindAsync(id);
            if (entity != null)
            {
                _context.Articulos.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
