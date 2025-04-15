using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClientesController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteDTO>>> GetAll()
        {
            var clientes = await _clienteService.ObtenerClientesAsync();
            var clientesDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);

            return Ok(clientesDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cliente = await _clienteService.GetByIdAsync(id);
            if (cliente == null)
                return NotFound();

            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);
            return Ok(clienteDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearClienteDTO dto)
        {
            try
            {
                var cliente = _mapper.Map<Cliente>(dto);
                await _clienteService.CreateAsync(cliente);
                return CreatedAtAction(nameof(Get), new { id = cliente.Id }, cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateClienteDTO updateClienteDTO)
        {
            if (id != updateClienteDTO.Id)
                return BadRequest("El Id del cliente no coincide");

            var cliente = _mapper.Map<Cliente>(updateClienteDTO);
            await _clienteService.UpdateAsync(cliente);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clienteService.DeleteAsync(id);
            return NoContent();
        }

    }
}
