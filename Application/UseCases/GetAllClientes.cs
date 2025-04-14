using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases
{
    public class GetAllClientes
    {
        private readonly IClienteRepository _clienteRepository;

        public GetAllClientes(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> ExecuteAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }
    }
}
