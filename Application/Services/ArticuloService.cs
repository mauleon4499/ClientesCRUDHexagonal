using AppLogic.DTOs;
using AppLogic.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace AppLogic.Services
{
    public class ArticuloService : IArticuloService
    {
        private readonly IArticuloRepository _repository;
        private readonly IMapper _mapper;

        public ArticuloService(IArticuloRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ArticuloDTO>> GetAllAsync()
        {
            var articulos = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ArticuloDTO>>(articulos);
        }

        public async Task<Articulo> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<Articulo> CreateAsync(Articulo articulo)
        {
            await _repository.AddAsync(articulo);
            return articulo;
        }

        public async Task UpdateAsync(Articulo articulo) => await _repository.UpdateAsync(articulo);

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task CrearArticuloAsync(CrearArticuloDTO dto)
        {
            var existe = (await _repository.GetAllAsync()).Any(c => c.Referencia == dto.Referencia);

            if (existe)
                throw new Exception("El articulo ya existe");

            var articulo = new Articulo
            {
                Referencia = dto.Referencia
            };

            await _repository.AddAsync(articulo);
        }

        public async Task<List<ArticuloDTO>> ObtenerArticulosAsync()
        {
            var articulos = await _repository.GetAllAsync();

            return articulos.Select(c => new ArticuloDTO
            {
                Id = c.Id,
                Referencia = c.Referencia
            }).ToList();
        }
    }
}
