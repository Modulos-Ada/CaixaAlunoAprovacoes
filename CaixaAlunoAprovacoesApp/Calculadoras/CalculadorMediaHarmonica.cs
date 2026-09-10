namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    public class CalculadorMediaHarmonica : ICalculadoraMedia
    {
        public decimal Calcular(decimal[] notas)
        {
            decimal somaInversos = 0;
            foreach (var nota in notas)
            {
                somaInversos += 1 / nota == 0 ? 1 : nota;
            }
            return notas.Length / somaInversos;
        }
    }
}
