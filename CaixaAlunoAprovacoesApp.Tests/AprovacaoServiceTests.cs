using CaixaAlunoAprovacoesApp.Services;
using CaixaAlunoAprovacoesApp.Tests.Fakes;

namespace CaixaAlunoAprovacoesApp.Tests
{
    public class AprovacaoServiceTests : TestsBase
    {
        [Fact]
        public void AlunoComMedia_EhAprovado()
        {
            var service = new AprovacaoService(FakeCalculadora(50), FakeReader(AlunoDefault));
            var aprovados = service.GetAprovados();

            Assert.NotEmpty(aprovados);
        }

        [Fact]
        public void AlunoSemMedia_EhReprovado()
        {
            //Arrange
            var calculadora = FakeCalculadora(30);
            var reader = FakeReader(AlunoDefault);
            var service = new AprovacaoService(calculadora, reader);

            //Act
            var aprovados = service.GetAprovados();

            //Assert
            Assert.Empty(aprovados);
        }
    }
}
