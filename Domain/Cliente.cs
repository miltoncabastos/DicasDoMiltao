namespace Domain
{
    public class Cliente
    {
        public Cliente(string nome, string cidade, string estado)
        {
            Nome = nome;
            Cidade = cidade;
            Estado = estado;
        }

        public string Nome { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}
