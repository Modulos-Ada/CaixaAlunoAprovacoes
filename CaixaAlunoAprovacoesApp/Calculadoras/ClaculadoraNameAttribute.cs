namespace CaixaAlunoAprovacoesApp.Calculadoras
{
    public class CalculadoraNameAttribute : Attribute
    {
        public CalculadoraNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
