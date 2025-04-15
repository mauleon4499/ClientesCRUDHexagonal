using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UbicacionesController : ControllerBase
    {
        private readonly IUbicacionService _ubicacionService;
        private readonly IMapper _mapper;

        public UbicacionesController(IUbicacionService ubicacionService, IMapper mapper)
        {
            _ubicacionService = ubicacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ubicaciones = await _ubicacionService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<UbicacionDTO>>(ubicaciones);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ubicacion = await _ubicacionService.GetByIdAsync(id);
            if (ubicacion == null) return NotFound();

            var dto = _mapper.Map<UbicacionDTO>(ubicacion);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearUbicacionDTO dto)
        {
            var ubicacion = _mapper.Map<Ubicacion>(dto);
            await _ubicacionService.CreateAsync(ubicacion);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUbicacionDTO dto)
        {
            dto.Id = id;
            var ubicacion = _mapper.Map<Ubicacion>(dto);
            await _ubicacionService.UpdateAsync(ubicacion);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ubicacionService.DeleteAsync(id);
            return Ok();
        }
    }
}
