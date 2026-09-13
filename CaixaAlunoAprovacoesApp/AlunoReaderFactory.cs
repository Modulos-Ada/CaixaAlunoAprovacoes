using CaixaAlunoAprovacoesApp.Readers;
using CaixaAlunoAprovacoesApp.Readers.ApiReader;

namespace CaixaAlunoAprovacoesApp
{
    public static class AlunoReaderFactory
    {
        public static IAlunoReader? Create(string tipo)
        {
            if (tipo.Equals("api", StringComparison.OrdinalIgnoreCase))
                return new ApiAlunoReader();

            return null;
        }
    }
}
