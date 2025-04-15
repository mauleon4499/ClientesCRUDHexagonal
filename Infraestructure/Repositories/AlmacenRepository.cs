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
    public class AlmacenRepository : IAlmacenRepository
    {
        private readonly AppDbContext _context;

        public AlmacenRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Almacen>> GetAllAsync()
        {
            return await _context.Almacenes.ToListAsync();
        }

        public async Task<Almacen> GetByIdAsync(int id)
        {
            return await _context.Almacenes.FindAsync(id);
        }

        public async Task AddAsync(Almacen entity)
        {
            _context.Almacenes.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Almacen entity)
        {
            _context.Almacenes.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Almacenes.FindAsync(id);
            if (entity != null)
            {
                _context.Almacenes.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

    }
}
