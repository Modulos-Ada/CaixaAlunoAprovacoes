using CaixaAlunoAprovacoesApp.Calculadoras;
using CaixaAlunoAprovacoesApp.DTO;
using CaixaAlunoAprovacoesApp.Readers;

namespace CaixaAlunoAprovacoesApp.Tests.Fakes
{
    public class TestsBase
    {
        public IAlunoReader FakeReader(params Aluno[] alunos)
            => new FakeReader(alunos);

        public ICalculadoraMedia FakeCalculadora(decimal media)
            => new CalculadoraFake(media);

        public Aluno AlunoDefault => new Aluno { RA = "RA123456", Nome = "Nome", Notas = [] };
    }
}