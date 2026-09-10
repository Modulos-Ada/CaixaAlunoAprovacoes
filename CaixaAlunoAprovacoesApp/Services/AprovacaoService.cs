using CaixaAlunoAprovacoesApp.Calculadoras;
using CaixaAlunoAprovacoesApp.DTO;
using CaixaAlunoAprovacoesApp.Readers;

namespace CaixaAlunoAprovacoesApp.Services
{
    public class AprovacaoService
    {
        private readonly ICalculadoraMedia calculadora;
        private readonly IAlunoReader[] readers;

        public AprovacaoService(ICalculadoraMedia calculadora, params IAlunoReader[] reader)
        {
            this.calculadora = calculadora;
            this.readers = reader;
        }

        public IEnumerable<Aluno> GetAprovados()
        {
            foreach (var reader in readers)
            {
                foreach (var aluno in reader.ReadAll())
                {
                    var media = calculadora.Calcular(aluno.Notas);
                    if (media >= 50)
                        yield return aluno;
                }
            }
        }
    }
}
