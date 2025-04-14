using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DireccionesController : Controller
    {
        private readonly IDireccionService _direccionService;

        public DireccionesController(IDireccionService direccionService)
        {
            _direccionService = direccionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var direcciones = await _direccionService.GetAllAsync();
            return Ok(direcciones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var direccion = await _direccionService.GetByIdAsync(id);
            if (direccion == null)
                return NotFound();

            return Ok(direccion);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Direccion direccion)
        {
            await _direccionService.CreateAsync(direccion);
            return CreatedAtAction(nameof(GetById), new { id = direccion.Id }, direccion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Direccion direccion)
        {
            if (id != direccion.Id)
                return BadRequest("El ID de la URL no coincide con el del cuerpo");

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
