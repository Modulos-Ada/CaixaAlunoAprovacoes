
namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    public class CalculadoraMediaAritmetica : ICalculadoraMedia
    {
        public decimal Calcular(decimal[] notas)
            => notas.Average();
    }
}
