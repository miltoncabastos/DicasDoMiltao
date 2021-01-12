using System.Diagnostics;

namespace Domain.Clientes
{
    [DebuggerDisplay("{Nome} - {Cidade}/{Estado}")]
    public class Cliente
    {
        public Cliente(string nome, string cidade, string estado)
        {
            Nome = nome;
            Cidade = cidade;
            Estado = estado;
        }

        public string Nome { get; }
        public string Cidade { get; }
        public string Estado { get; }
    }
}
