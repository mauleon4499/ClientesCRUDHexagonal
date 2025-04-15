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
    public class UbicacionService : IUbicacionService
    {
        private readonly IUbicacionRepository _repository;
        private readonly IMapper _mapper;

        public UbicacionService(IUbicacionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UbicacionDTO>> GetAllAsync()
        {
            var ubicaciones = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<UbicacionDTO>>(ubicaciones);
        }

        public async Task<Ubicacion> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Ubicacion> CreateAsync(Ubicacion ubicacion)
        {
            await _repository.AddAsync(ubicacion);
            return ubicacion;
        }

        public async Task UpdateAsync(Ubicacion ubicacion) => await _repository.UpdateAsync(ubicacion);

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task CrearUbicacionAsync(CrearUbicacionDTO dto)
        {
            var existe = (await _repository.GetAllAsync()).Any(u => u.Referencia == dto.Referencia);

            if (existe)
                throw new Exception("La ubicación ya existe");

            var ubicacion = new Ubicacion
            {
                Referencia = dto.Referencia
            };

            await _repository.AddAsync(ubicacion);
        }

        public async Task<List<UbicacionDTO>> ObtenerUbicacionesAsync()
        {
            var ubicacions = await _repository.GetAllAsync();

            return ubicacions.Select(c => new UbicacionDTO
            {
                Referencia = c.Referencia,
                IdAlmacen = c.IdAlmacen
            }).ToList();
        }
    }
}
