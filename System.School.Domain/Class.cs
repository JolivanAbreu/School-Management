public class Turma()
{
    static int contador = 1;

    public int Numero { get; set; }
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; }
    public List<Disciplina> Disciplina { get; set; }
    public double MediaTurma { get; set; }
    public int QuantidadeAlunos { get; set; }
    public string SituacaoTurma { get; set; }
    public Professor Professor { get; set; }

    public int GerarMatricula()
    {
        string anoAtual = DateTime.Now.Year.ToString();
        string id = contador.ToString("D3"); // Formata com três dígitos (ex: 001, 002)

        contador++;

        return int.Parse($"{anoAtual}{id}"); // Converte a string "2025001" para int
    }
}