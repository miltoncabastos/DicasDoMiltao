using Domain.Clientes;
using System.Collections.Generic;

namespace Repository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ObterClientesPorCidadeEstado(string cidade, string estado);
    }
}
