namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    static partial class CalculadoraType
    {
        public const string Aritmetica = "Aritmetica";
    }


    public class CalculadoraMediaAritmetica : ICalculadoraMedia
    {
        public decimal Calcular(decimal[] notas)
            => notas.Average();
    }
}
