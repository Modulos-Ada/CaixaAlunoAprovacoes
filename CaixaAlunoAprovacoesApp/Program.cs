using CaixaAlunoAprovacoesApp.Calculadoras;
using CaixaAlunoAprovacoesApp.Readers;
using CaixaAlunoAprovacoesApp.Services;

namespace CaixaAlunoAprovacoesApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            var dbReader = new DatabaseAlunoReader();
            var csvReader = new CsvAlunoReader();
            var calculadora = new CalculadoraMediaAritmetica();

            var service = new AprovacaoService(calculadora, dbReader, csvReader);

            foreach (var aluno in service.GetAprovados())
            {
                Console.WriteLine($"{aluno.RA} - {aluno.Nome} - {string.Join(",", aluno.Notas)}");
            }
        }
    }
}
