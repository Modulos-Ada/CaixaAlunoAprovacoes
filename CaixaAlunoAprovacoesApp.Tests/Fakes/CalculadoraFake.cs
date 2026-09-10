using CaixaAlunoAprovacoesApp.Calculadoras;

namespace CaixaAlunoAprovacoesApp.Tests.Fakes
{
    class CalculadoraFake : ICalculadoraMedia
    {
        private readonly decimal retorno;
        public CalculadoraFake(decimal retorno) => this.retorno = retorno;

        public decimal Calcular(decimal[] notas)
            => retorno;
    }
}
