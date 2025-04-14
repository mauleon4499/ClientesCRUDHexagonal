using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class DireccionService : IDireccionService
    {
        private readonly IDireccionRepository _direccionRepository;

        public DireccionService(IDireccionRepository direccionRepository)
        {
            _direccionRepository = direccionRepository;
        }

        public async Task<IEnumerable<Direccion>> GetAllAsync()
        {
            return await _direccionRepository.GetAllAsync();
        }

        public async Task<Direccion> GetByIdAsync(int id)
        {
            return await _direccionRepository.GetByIdAsync(id);
        }

        public async Task CreateAsync(Direccion direccion)
        {
            await _direccionRepository.AddAsync(direccion);
        }

        public async Task UpdateAsync(Direccion direccion)
        {
            await _direccionRepository.UpdateAsync(direccion);
        }

        public async Task DeleteAsync(int id)
        {
            await _direccionRepository.DeleteAsync(id);
        }
    }
}
