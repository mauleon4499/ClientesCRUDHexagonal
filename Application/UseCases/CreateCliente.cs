using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases
{
    public class CreateCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public CreateCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task ExecuteAsync(string nombre, string email)
        {
            var cliente = new Cliente
            {
                Nombre = nombre,
                Email = email
            };

            await _clienteRepository.AddAsync(cliente);
        }
    }
}
