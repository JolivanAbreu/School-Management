public class CAluno
{
    public static List<Aluno> listaAlunos = new List<Aluno>();
    public static void CadastrarAlunos()
    {
        Aluno aluno = new Aluno();
        Console.WriteLine("\n====== Cadastrar Aluno ======");

        aluno.Matricula = aluno.GerarMatricula(); // Gera a matrícula automaticamente
        Console.WriteLine($"Matrícula: {aluno.Matricula}"); // Exibe a matrícula gerada automaticamente

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        aluno.Idade = int.Parse(Console.ReadLine());

        Console.Write("Nota 1: ");
        aluno.Nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        aluno.Nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3: ");
        aluno.Nota3 = double.Parse(Console.ReadLine());

        listaAlunos.Add(aluno);

        Console.WriteLine("\n✅ Cadastro realizado com sucesso!\n");

        return;
    }
}