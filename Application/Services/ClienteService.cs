using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync() => await _clienteRepository.GetAllAsync();

        public async Task<Cliente> GetByIdAsync(int id) => await _clienteRepository.GetByIdAsync(id);

        public async Task<Cliente> CreateAsync(Cliente cliente)
        {
            await _clienteRepository.AddAsync(cliente);
            return cliente;
        }

        public async Task UpdateAsync(Cliente cliente) => await _clienteRepository.UpdateAsync(cliente);

        public async Task DeleteAsync(int id) => await _clienteRepository.DeleteAsync(id);

        public async Task CrearClienteAsync(CrearClienteDTO dto)
        {
            var existe = (await _clienteRepository.GetAllAsync()).Any(c => c.Email == dto.Email);
            
            if(existe)
                throw new Exception("El cliente ya existe");

            var cliente = new Cliente
            {
                Nombre = dto.Nombre,
                Email = dto.Email
            };

            await _clienteRepository.AddAsync(cliente);
        }

        public async Task<List<ClienteDTO>> ObtenerClientesAsync()
        {
            var clientes = await _clienteRepository.GetAllAsync();

            return clientes.Select(c => new ClienteDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Email = c.Email
            }).ToList();
        }
    }
}
