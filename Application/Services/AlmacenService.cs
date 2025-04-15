using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class AlmacenService : IAlmacenService
    {
        private readonly IAlmacenRepository _repository;
        private readonly IMapper _mapper;

        public AlmacenService(IAlmacenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AlmacenDTO>> GetAllAsync()
        {
            var almacenes = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<AlmacenDTO>>(almacenes);
        }

        public async Task<Almacen> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Almacen> CreateAsync(Almacen almacen)
        {
            await _repository.AddAsync(almacen);
            return almacen;
        }

        public async Task UpdateAsync(Almacen almacen) => await _repository.UpdateAsync(almacen);

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task CrearAlmacenAsync(CrearAlmacenDTO dto)
        {
            var existe = (await _repository.GetAllAsync()).Any(c => c.Referencia == dto.Referencia);

            if (existe)
                throw new Exception("El almacen ya existe");

            var almacen = new Almacen
            {
                Referencia = dto.Referencia
            };

            await _repository.AddAsync(almacen);
        }

        public async Task<List<AlmacenDTO>> ObtenerAlmacenesAsync()
        {
            var almacenes = await _repository.GetAllAsync();

            return almacenes.Select(c => new AlmacenDTO
            {
                Id = c.Id,
                Referencia = c.Referencia
            }).ToList();
        }
    }
}
