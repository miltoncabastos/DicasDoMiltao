using Domain.Clientes;
using System.Collections.Generic;

namespace Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public IEnumerable<Cliente> ObterClientesPorCidadeEstado(string cidade, string estado)
        {
            return default;
        }        
    }
}
