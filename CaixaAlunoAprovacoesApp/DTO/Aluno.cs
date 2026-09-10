namespace CaixaAlunoAprovacoesApp.DTO
{
    public class Aluno
    {
        public required string RA { get; set; }
        public required string Nome { get; set; }
        public decimal[] Notas { get; set; }
    }
}
