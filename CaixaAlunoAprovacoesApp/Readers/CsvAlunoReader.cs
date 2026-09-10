using CaixaAlunoAprovacoesApp.DTO;

namespace CaixaAlunoAprovacoesApp.Readers
{
    public class CsvAlunoReader : IAlunoReader
    {
        public IEnumerable<Aluno> ReadAll()
        {
            var linhas = File.ReadAllLines("alunos.csv");
            foreach (var linha in linhas)
            {
                var partes = linha.Split(',');
                yield return new Aluno
                {
                    RA = partes[0],
                    Nome = partes[1],
                    Notas = new decimal[]
                    {
                        decimal.Parse(partes[2]),
                        decimal.Parse(partes[3]),
                        decimal.Parse(partes[4]),
                        decimal.Parse(partes[5])
                    }
                };
            }
        }
    }
}
