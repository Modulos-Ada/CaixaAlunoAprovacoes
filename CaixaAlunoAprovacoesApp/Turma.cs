using CaixaAlunoAprovacoesApp.DTO;
using System.Collections;

namespace CaixaAlunoAprovacoesApp
{
    public class Turma : IEnumerable<Aluno>
    {
        private List<Aluno> alunos = [];
        public string Disciplina { get; }

        public Turma(string disciplina)
        {
            Disciplina = disciplina;
        }

        public IEnumerator<Aluno> GetEnumerator()
        {
            return alunos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Matricular(IEnumerable<Aluno> alunos)
        {
            this.alunos.AddRange(alunos);
        }
    }
}
