using CaixaAlunoAprovacoesApp.DTO;
using System.Net;

namespace CaixaAlunoAprovacoesApp.Readers.ApiReader
{
    public class ApiAlunoReader : IAlunoReader
    {
        public IEnumerable<Aluno> ReadAll()
        {
            using var client = new WebClient();
            var response = client.DownloadString(@"https://mocks.stradioti.cloud/api/alunos");
            var responseAlunos = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<AlunoApiDto>>(response, System.Text.Json.JsonSerializerOptions.Web);

            foreach (var aluno in responseAlunos)
            {
                yield return new Aluno
                { 
                    RA = aluno.ra,
                    Nome = aluno.nome,
                    Notas = aluno.matriculas.FirstOrDefault()!.notas
                };
            }
        }
    }
}
