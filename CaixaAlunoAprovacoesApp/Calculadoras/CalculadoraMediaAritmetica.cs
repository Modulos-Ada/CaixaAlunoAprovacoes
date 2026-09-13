
namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    static partial class CalculadoraType
    {
        public const string Aritmetica = "Aritmetica";
    }


    [CalculadoraName(CalculadoraType.Aritmetica)]
    public class CalculadoraMediaAritmetica : ICalculadoraMedia
    {
        partial class CalculadoraType
        {
            public const string Aritmetica = "Aritmetica";
        }
        public decimal Calcular(decimal[] notas)
            => notas.Average();
    }
}
