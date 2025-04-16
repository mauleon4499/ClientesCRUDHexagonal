using AppLogic.DTOs;
using AppLogic.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventariosController : ControllerBase
    {
        private readonly IInventarioService _inventarioService;
        private readonly IMapper _mapper;

        public InventariosController(IInventarioService inventarioService, IMapper mapper)
        {
            _inventarioService = inventarioService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var inventarios = await _inventarioService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<InventarioDTO>>(inventarios);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var inventario = await _inventarioService.GetByIdAsync(id);
            if (inventario == null) return NotFound();

            var dto = _mapper.Map<InventarioDTO>(inventario);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearInventarioDTO dto)
        {
            var inventario = _mapper.Map<Inventario>(dto);
            await _inventarioService.CreateAsync(inventario);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateInventarioDTO dto)
        {
            dto.Id = id;
            var inventario = _mapper.Map<Inventario>(dto);
            await _inventarioService.UpdateAsync(inventario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _inventarioService.DeleteAsync(id);
            return Ok();
        }
    }
}
