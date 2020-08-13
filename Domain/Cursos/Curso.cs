namespace Domain.Cursos
{
    public class Curso
    {
        public Curso(string nome, int duracao)
        {
            Nome = nome;
            Duracao = duracao;
        }

        public string Nome { get; private set; }
        public int Duracao { get; private set; }
    }
}
