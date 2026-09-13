using CaixaAlunoAprovacoesApp.Calculadoras;

namespace CaixaAlunoAprovacoesApp
{
    public static class CalculadoraFactory
    {
        public static ICalculadoraMedia? Create(string tipo)
        {
            if (tipo.Equals(CalculadoraType.Aritmetica, StringComparison.OrdinalIgnoreCase))
                return new CalculadoraMediaAritmetica();

            else if (tipo.Equals(CalculadoraType.Ponderada, StringComparison.OrdinalIgnoreCase))
                return new CalculadoraMediaPonderada();

            else if (tipo.Equals(CalculadoraType.Harmonica, StringComparison.OrdinalIgnoreCase))
                return new CalculadoraMediaHarmonica();

            return null;
        }
    }
}
