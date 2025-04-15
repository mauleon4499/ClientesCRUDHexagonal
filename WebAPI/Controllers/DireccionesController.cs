using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DireccionesController : Controller
    {
        private readonly IDireccionService _direccionService;
        private readonly IMapper _mapper;

        public DireccionesController(IDireccionService direccionService, IMapper mapper)
        {
            _direccionService = direccionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var direcciones = await _direccionService.GetAllAsync();
            var direccionesDTO = _mapper.Map<IEnumerable<DireccionDTO>>(direcciones);

            return Ok(direccionesDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var direccion = await _direccionService.GetByIdAsync(id);
            if (direccion == null)
                return NotFound();

            var direccionDTO = _mapper.Map<DireccionDTO>(direccion);
            return Ok(direccionDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearDireccionDTO crearDireccionDTO)
        {
            var direccion = _mapper.Map<Direccion>(crearDireccionDTO);
            await _direccionService.CreateAsync(direccion);
            return CreatedAtAction(nameof(GetById), new { id = direccion.Id }, direccion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateDireccionDTO updateDireccionDTO)
        {
            if (id != updateDireccionDTO.Id)
                return BadRequest("El ID de la dirección no coincide");

            var direccion = _mapper.Map<Direccion>(updateDireccionDTO);
            await _direccionService.UpdateAsync(direccion);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _direccionService.DeleteAsync(id);
            return NoContent();
        }
    }
}
