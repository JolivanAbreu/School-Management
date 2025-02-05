public class RemAluno
{
    public static void RemoverAlunos()
    {
        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para remover.");
        }

        Console.Write("\n===== Exclução de Alunos =====");

        Console.Write("\nDigite a matricula do aluno: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\nNúmero de inválido!");
            Console.Write("\n Informe uma matrícula valida: ");
        }

        Aluno aluno = CAluno.listaAlunos.Find(a => a.Matricula == matricula);

        if (aluno == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        CAluno.listaAlunos.Remove(aluno);
        Console.WriteLine("\n✅ Aluno removido com sucesso!");
    }
}