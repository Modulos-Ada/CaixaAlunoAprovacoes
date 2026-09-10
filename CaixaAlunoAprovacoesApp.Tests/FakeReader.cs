using CaixaAlunoAprovacoesApp.DTO;
using CaixaAlunoAprovacoesApp.Readers;

namespace CaixaAlunoAprovacoesApp.Tests
{
    class FakeReader : IAlunoReader
    {
        private readonly Aluno[] alunos;
        public FakeReader(params Aluno[] alunos) => this.alunos = alunos;

        public IEnumerable<Aluno> ReadAll()
            => alunos;
    }
}
