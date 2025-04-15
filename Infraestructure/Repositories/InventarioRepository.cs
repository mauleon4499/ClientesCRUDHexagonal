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
    public class InventarioRepository : IInventarioRepository
    {
        private readonly AppDbContext _context;

        public InventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inventario>> GetAllAsync()
        {
            return await _context.Inventarios
                .Include(i => i.Articulo)
                .Include(i => i.Ubicacion)
                .ToListAsync();
        }

        public async Task<Inventario> GetByIdAsync(int id)
        {
            return await _context.Inventarios
                .Include(i => i.Articulo)
                .Include(i => i.Ubicacion)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task AddAsync(Inventario entity)
        {
            _context.Inventarios.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Inventario entity)
        {
            _context.Inventarios.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Inventarios.FindAsync(id);
            if (entity != null)
            {
                _context.Inventarios.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
