using CaixaAlunoAprovacoesApp.DTO;
using Npgsql;

namespace CaixaAlunoAprovacoesApp.Readers
{
    public class DatabaseAlunoReader : IAlunoReader
    {
        private readonly NpgsqlConnection connection;

        public DatabaseAlunoReader()
        {
            var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=SenhaForte123!";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        public IEnumerable<Aluno> ReadAll()
        {
            var sql = "SELECT RA, Nome, Nota1, Nota2, Nota3, Nota4 FROM Alunos";
            using var command = new NpgsqlCommand(sql, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                yield return new Aluno 
                { 
                    RA = reader.GetString(0),
                    Nome = reader.GetString(1),
                    Notas = [reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetDecimal(5)]
                };
            }
        }
    }
}
