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
    public class UbicacionRepository : IUbicacionRepository
    {
        private readonly AppDbContext _context;

        public UbicacionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ubicacion>> GetAllAsync()
        {
            return await _context.Ubicaciones.ToListAsync();
        }

        public async Task<Ubicacion> GetByIdAsync(int id)
        {
            return await _context.Ubicaciones.FindAsync(id);
        }

        public async Task AddAsync(Ubicacion entity)
        {
            _context.Ubicaciones.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Ubicacion entity)
        {
            _context.Ubicaciones.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Ubicaciones.FindAsync(id);
            if (entity != null)
            {
                _context.Ubicaciones.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
