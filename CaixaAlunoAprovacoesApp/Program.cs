using CaixaAlunoAprovacoesApp.Calculadoras;
using CaixaAlunoAprovacoesApp.Services;
using System.Reflection;

namespace CaixaAlunoAprovacoesApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.IsAssignableTo(typeof(ICalculadoraMedia)) &&
                            x.GetCustomAttribute<CalculadoraNameAttribute>() != null &&
                            !x.IsAbstract &&
                            !x.IsInterface);


            return;

            if (args.Length < 2)
            {
                Console.WriteLine("Uso: <calculadora> <reader>");
                Console.WriteLine(" Calculadoras:");
                Console.WriteLine($"    {CalculadoraType.Aritmetica}");
                Console.WriteLine($"    {CalculadoraType.Ponderada}");
                Console.WriteLine($"    {CalculadoraType.Harmonica}");
                Console.WriteLine();
                Console.WriteLine(" Readers:");
                Console.WriteLine("     API");

                return;
            }

            var tipoCalculadora = args[0].ToLower();
            var tipoReader = args[1].ToLower();

            var calculadora = CalculadoraFactory.Create(tipoCalculadora);
            var reader = AlunoReaderFactory.Create(tipoReader);

            var service = new AprovacaoService(calculadora, reader);

            //foreach (var aluno in service.GetAprovados())
            //{
            //    Console.WriteLine($"{aluno.RA} - {aluno.Nome} - {string.Join(",", aluno.Notas)}");
            //}
        }
    }
}
