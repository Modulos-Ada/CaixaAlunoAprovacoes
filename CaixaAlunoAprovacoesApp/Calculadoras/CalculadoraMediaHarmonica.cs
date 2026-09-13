namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    public class CalculadoraMediaHarmonica : ICalculadoraMedia
    {
        // A média harmônica é calculada dividindo a quantidade de valores
        // pela soma dos seus inversos.
        // Ela é usada quando os valores representam taxas ou proporções,
        // dando menos peso aos maiores números.
        public decimal Calcular(decimal[] notas)
        {
            if (notas.Any(x => x == 0))
                throw new InvalidOperationException("Não é possível calcular a média harmônica quando a amostra contém zeros.");

            decimal somaInversos = 0;
            foreach (var nota in notas)
                somaInversos += 1 / nota;

            return notas.Length / somaInversos;
        }
    }
}
