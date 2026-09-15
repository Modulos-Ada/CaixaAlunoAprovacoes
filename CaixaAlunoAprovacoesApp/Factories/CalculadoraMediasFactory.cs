using CaixaAlunoAprovacoesApp.Calculadoras;

namespace CaixaAlunoAprovacoesApp.Factories
{
    public static class CalculadoraMediasFactory
    {
        public static ICalculadoraMedia Create(string nome)
        {
            if (nome == nameof(CalculadoraMediaAritmetica))
                return new CalculadoraMediaAritmetica();

            else if (nome == nameof(CalculadoraMediaPonderada))
                return new CalculadoraMediaPonderada();

            else if (nome == nameof(CalculadoraMediaHarmonica))
                return new CalculadoraMediaHarmonica();

            throw new Exception("Algorimo não suportado");
        }
    }
}
