using Application.Interfaces;
using Application.Services;
using AppLogic.DTOs;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlmacenesController : ControllerBase
    {
        private readonly IAlmacenService _almacenService;
        private readonly IMapper _mapper;

        public AlmacenesController(IAlmacenService almacenService, IMapper mapper)
        {
            _almacenService = almacenService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var almacenes = await _almacenService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<AlmacenDTO>>(almacenes);
            return Ok(dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var almacen = await _almacenService.GetByIdAsync(id);
            if (almacen == null) return NotFound();

            var dto = _mapper.Map<AlmacenDTO>(almacen);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearAlmacenDTO dto)
        {
            var almacen = _mapper.Map<Almacen>(dto);
            await _almacenService.CreateAsync(almacen);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAlmacenDTO dto)
        {
            if (id != dto.Id)
                return BadRequest("El Id del cliente no coincide");

            var almacen = _mapper.Map<Almacen>(dto);
            await _almacenService.UpdateAsync(almacen);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _almacenService.DeleteAsync(id);
            return Ok();
        }

    }
}
