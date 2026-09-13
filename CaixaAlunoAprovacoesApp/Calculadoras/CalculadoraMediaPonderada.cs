namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    public class CalculadoraPonderadaOptions : CalculadoraOptions
    {
        public CalculadoraPonderadaOptions(string pesos)
        {
            Pesos = pesos.Split(',').Select(decimal.Parse).ToArray();
        }

        public decimal[] Pesos { get; }
    }

    public class CalculadoraMediaPonderada : ICalculadoraMedia
    {
        private readonly CalculadoraPonderadaOptions options;

        public CalculadoraMediaPonderada(CalculadoraPonderadaOptions options)
        {
            this.options = options;
        }

        public decimal Calcular(decimal[] notas)
        {
            return (notas[0] * options.Pesos[0] +
                    notas[1] * options.Pesos[1] +
                    notas[2] * options.Pesos[2] +
                    notas[3] * options.Pesos[3]) / options.Pesos.Sum();
        }
    }
}
