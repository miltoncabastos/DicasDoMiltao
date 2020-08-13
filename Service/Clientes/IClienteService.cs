using System.Collections.Generic;
using Domain.Clientes;

namespace Service.Clientes
{
    public interface IClienteService
    {
        IEnumerable<Cliente> ObterClientesDaCidadeEstado(string cidade, string estado);
    }
}
