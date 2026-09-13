using CaixaAlunoAprovacoesApp.Calculadoras;
using System.Reflection;
using Xunit.Abstractions;


namespace CaixaAlunoAprovacoesApp.Tests
{
    public class Class1
    {
        private readonly ITestOutputHelper helper;

        public Class1(ITestOutputHelper helper) => this.helper = helper;

        [Fact]
        public void TesteArquitetura()
        {
            var x = typeof(ICalculadoraMedia).Assembly.GetTypes()
                .Where(x => x.IsAssignableTo(typeof(ICalculadoraMedia)) &&
                            !x.IsInterface &&
                            !x.IsAbstract);

            foreach (var type in x)
            {
                var hasAnnotation = type.GetCustomAttribute<CalculadoraNameAttribute>();
                if (hasAnnotation is null)
                    helper.WriteLine($"Tipo {type.FullName} não possui anotação CalculadoraNameAttribute");
            }
        }
    }
}
