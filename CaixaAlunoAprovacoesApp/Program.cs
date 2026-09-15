using CaixaAlunoAprovacoesApp.Factories;

namespace CaixaAlunoAprovacoesApp
{
    public static class Program
    {
        static void Main(string[] argumentos)
        {
            var nomeCalculadora = argumentos[0];
            var nomeReader = argumentos[1];

            var calculadora = CalculadoraMediasFactory.Create(nomeCalculadora);
            var reader = AlunoReaderFactory.Create(nomeReader);

            var classe = new Turma("POO 2");
            classe.Matricular(reader.ReadAll());

            foreach (var aluno in classe)
            {
                Console.WriteLine($"{aluno.Nome} - {calculadora.Calcular(aluno.Notas)}");
            }

            /*
            var service = new AprovacaoService(calculadora, reader);
            foreach (var aluno in service.GetAprovados())
            {
                Console.WriteLine($"{aluno.RA} - {aluno.Nome} - {string.Join(",", aluno.Notas)}");
            }
            */
        }
    }
}
