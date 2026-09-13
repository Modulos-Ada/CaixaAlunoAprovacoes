using CaixaAlunoAprovacoesApp.Calculadoras;
using CaixaAlunoAprovacoesApp.Readers.ApiReader;
using CaixaAlunoAprovacoesApp.Services;

namespace CaixaAlunoAprovacoesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Uso: <calculadora> <reader>");
                Console.WriteLine(" Calculadoras:");
                Console.WriteLine($"    {nameof(CalculadoraMediaAritmetica)}");
                Console.WriteLine($"    {nameof(CalculadoraMediaPonderada)}");
                Console.WriteLine($"    {nameof(CalculadoraMediaHarmonica)}");
                Console.WriteLine();
                Console.WriteLine(" Readers:");
                Console.WriteLine($"     {nameof(ApiAlunoReader)}");

                return;
            }

            var tipoCalculadora = args[0].ToLower();
            var tipoReader = args[1].ToLower();

            var pesos = Environment.GetEnvironmentVariable("Pesos") ?? "1,1,1,3";
            var options = new CalculadoraPonderadaOptions(pesos);

            var calculadora = CalculadoraFactory.Create(tipoCalculadora, options);



            var reader = AlunoReaderFactory.Create(tipoReader);
            var service = new AprovacaoService(calculadora, reader);

            foreach (var aluno in service.GetAprovados())
            {
                Console.WriteLine($"{aluno.RA} - {aluno.Nome} - {string.Join(",", aluno.Notas)}");
            }
        }
    }
}
