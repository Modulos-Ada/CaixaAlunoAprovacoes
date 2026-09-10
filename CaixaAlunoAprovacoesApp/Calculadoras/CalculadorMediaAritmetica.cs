namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    public class CalculadorMediaAritmetica : ICalculadoraMedia
    {
        public decimal Calcular(decimal[] notas)
            => notas.Average();
    }
}
