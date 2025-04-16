using AppLogic.DTOs;
using AppLogic.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace AppLogic.Services
{
    public class InventarioService : IInventarioService
    {
        private readonly IInventarioRepository _repository;
        private readonly IMapper _mapper;

        public InventarioService(IInventarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InventarioDTO>> GetAllAsync()
        {
            var items = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<InventarioDTO>>(items);
        }

        public async Task<Inventario> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Inventario> CreateAsync(Inventario inventario)
        {
            await _repository.AddAsync(inventario);
            return inventario;
        }

        public async Task UpdateAsync(Inventario inventario) => await _repository.UpdateAsync(inventario);

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task CrearInventarioAsync(CrearInventarioDTO dto)
        {
            var existe = (await _repository.GetAllAsync()).Any(i => i.IdArticulo == dto.IdArticulo && i.IdUbicacion == dto.IdUbicacion);

            if (existe)
                throw new Exception("El inventario ya existe");

            var inventario = new Inventario
            {
                IdArticulo = dto.IdArticulo,
                IdUbicacion = dto.IdUbicacion,
                Cantidad = dto.Cantidad
            };

            await _repository.AddAsync(inventario);
        }

        public async Task<List<InventarioDTO>> ObtenerInventariosAsync()
        {
            var inventarios = await _repository.GetAllAsync();

            return inventarios.Select(c => new InventarioDTO
            {
                Id = c.Id,
                IdArticulo  = c.IdArticulo,
                IdUbicacion = c.IdUbicacion,
            }).ToList();
        }
    }
}
