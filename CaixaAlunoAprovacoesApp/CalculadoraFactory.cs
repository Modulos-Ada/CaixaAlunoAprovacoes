using CaixaAlunoAprovacoesApp.Calculadoras;
using System.Reflection;

namespace CaixaAlunoAprovacoesApp
{
    public static class CalculadoraFactory
    {
        private static Dictionary<string, Type> tiposCalculadoras = new Dictionary<string, Type>(StringComparer.InvariantCultureIgnoreCase);

        static CalculadoraFactory()
        {
            tiposCalculadoras = Assembly.GetExecutingAssembly().GetTypes()
                  .Where(x => x.IsAssignableTo(typeof(ICalculadoraMedia)) && !x.IsInterface)
                  .ToDictionary(x => x.Name, x => x, StringComparer.OrdinalIgnoreCase);
        }

        public static ICalculadoraMedia? Create(string tipo, CalculadoraOptions? options)
        {
            tiposCalculadoras.TryGetValue(tipo, out var type);

            if (type is null)
                return null;

            var instancia = options == null ? Activator.CreateInstance(type) : Activator.CreateInstance(type, options);

            return instancia as ICalculadoraMedia;
        }
    }
}
