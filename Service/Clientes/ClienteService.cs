using Domain.Clientes;
using Repository;
using System.Collections.Generic;

namespace Service.Clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesDaCidadeEstado(string cidade, string estado)
        {
            return _clienteRepository.ObterClientesPorCidadeEstado(cidade, estado);
        }
    }
}
