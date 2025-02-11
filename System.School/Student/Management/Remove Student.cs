public class RemAluno
{
    public static void RemoverAlunos()
    {
        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para remoção.");
            return;
        }

        Console.WriteLine("\n===== 🗑️ Exclusão de Alunos =====");
        Console.Write("🔢 Digite a matrícula do aluno: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\nNúmero de inválido!");
            Console.Write("\n Informe uma matrícula valida: ");
        }

        Aluno aluno = CAluno.listaAlunos.Find(a => a.Matricula == matricula);

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\n⚠️ Número inválido! Informe uma matrícula válida: ");
        }

        if (aluno == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        CAluno.listaAlunos.Remove(aluno);
        Console.WriteLine("\n✅ Aluno removido com sucesso!");
    }
}