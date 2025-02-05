public class Turma()
{
    //static int contador = 1;

    public int Numero { get; set; }
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; }
    public double MediaTurma { get; set; }
    public int QuantidadeAlunos { get; set; }
    public string SituacaoTurma { get; set; }
    public List<Professor> Professor {get; set;}
}