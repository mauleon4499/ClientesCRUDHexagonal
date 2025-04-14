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
    public class DireccionRepository : IDireccionRepository
    {
        private readonly AppDbContext _context;

        public DireccionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Direccion direccion)
        {
            _context.Direcciones.Add(direccion);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Direccion>> GetAllAsync()
        {
            return await _context.Direcciones.ToListAsync();
        }

        public async Task<Direccion> GetByIdAsync(int id)
        {
            return await _context.Direcciones.FindAsync(id);
        }

        public async Task UpdateAsync(Direccion direccion)
        {
            _context.Direcciones.Update(direccion);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var direccion = await _context.Direcciones.FindAsync(id);
            if (direccion != null)
            {
                _context.Direcciones.Remove(direccion);
                await _context.SaveChangesAsync();
            }
        }
    }
}
