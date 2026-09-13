using CaixaAlunoAprovacoesApp.Calculadoras;

namespace CaixaAlunoAprovacoesApp
{
    public static class CalculadoraFactory
    {
        public static ICalculadoraMedia? Create(string tipo)
        {
            if (tipo.Equals(nameof(CalculadoraMediaAritmetica), StringComparison.OrdinalIgnoreCase))
                return new CalculadoraMediaAritmetica();

            else if (tipo.Equals(nameof(CalculadoraMediaPonderada), StringComparison.OrdinalIgnoreCase))
                return new CalculadoraMediaPonderada();

            else if (tipo.Equals(nameof(CalculadoraMediaHarmonica), StringComparison.OrdinalIgnoreCase))
                return new CalculadoraMediaHarmonica();

            return null;
        }
    }
}
