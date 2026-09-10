using CaixaAlunoAprovacoesApp.DTO;

namespace CaixaAlunoAprovacoesApp.Readers
{
    public interface IAlunoReader
    {
        public IEnumerable<Aluno> ReadAll();
    }
}
