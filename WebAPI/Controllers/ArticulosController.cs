using AppLogic.DTOs;
using AppLogic.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ArticulosController : ControllerBase
    {
        private readonly IArticuloService _articuloService;
        private readonly IMapper _mapper;

        public ArticulosController(IArticuloService articuloService, IMapper mapper)
        {
            _articuloService = articuloService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articulos = await _articuloService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<ArticuloDTO>>(articulos);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var articulo = await _articuloService.GetByIdAsync(id);
            if (articulo == null) return NotFound();

            var dto = _mapper.Map<ArticuloDTO>(articulo);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearArticuloDTO dto)
        {
            var articulo = _mapper.Map<Articulo>(dto);
            await _articuloService.CreateAsync(articulo);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateArticuloDTO dto)
        {
            if (id != dto.Id)
                return BadRequest("El Id del cliente no coincide");

            var articulo = _mapper.Map<Articulo>(dto);
            await _articuloService.UpdateAsync(articulo);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _articuloService.DeleteAsync(id);
            return Ok();
        }

    }
}
