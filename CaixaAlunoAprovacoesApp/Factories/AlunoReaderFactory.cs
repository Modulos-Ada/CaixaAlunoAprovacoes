using CaixaAlunoAprovacoesApp.Readers;
using System.Reflection;

namespace CaixaAlunoAprovacoesApp.Factories
{
    public  class AlunoReaderFactory
    {
        private static Dictionary<string, Type> tipos = [];
        static AlunoReaderFactory()
        {
            tipos = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsAssignableTo(typeof(IAlunoReader)) &&
                            !x.IsInterface &&
                            !x.IsAbstract)
            .ToDictionary(x => x.Name, x => x);
        }

        public static IAlunoReader Create(string nome)
        {
            tipos.TryGetValue(nome, out var tipo);
            ArgumentException.ThrowIfNullOrEmpty(nameof(tipo), "O tipo de reader informado não é suportado");

            var instancia = Activator.CreateInstance(tipo!) as IAlunoReader;
            if (instancia == null)
                throw new Exception("Erro ao inicializar o reader");

            return instancia;
        }
    }
}