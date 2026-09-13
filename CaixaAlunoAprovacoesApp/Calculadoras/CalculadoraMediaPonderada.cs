namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    static partial class CalculadoraType
    {
        public const string Ponderada = "Ponderada";
    }

    [CalculadoraName(CalculadoraType.Ponderada)]
    public class CalculadoraMediaPonderada : ICalculadoraMedia
    {
        public decimal Calcular(decimal[] notas)
        {
            return (notas[0] * 1 + notas[1] * 2 + notas[2] * 3 + notas[3] * 4) / 10;
        }
    }
}
