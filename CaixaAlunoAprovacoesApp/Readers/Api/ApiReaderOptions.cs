using CaixaAlunoAprovacoesApp.Readers.ApiReader;

namespace CaixaAlunoAprovacoesApp.Readers.Api
{
    public class ApiReaderOptions : ReaderOptions<ApiAlunoReader>
    {
        public string WebServiceUrl { get; set; }

    }
}
