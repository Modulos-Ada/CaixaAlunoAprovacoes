using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaAlunoAprovacoesApp.Readers.ApiReader
{

    public class ApiResponseDto
    {
        public AlunoApiDto[] Alunos { get; set; }
    }

    public class AlunoApiDto
    {
        public string ra { get; set; }
        public string nome { get; set; }
        public MatriculaApiDto[] matriculas { get; set; } = [];
    }

    public class MatriculaApiDto
    {
        public int id { get; set; }
        public string disciplina { get; set; }
        public decimal[] notas { get; set; } = [];
    }

}
