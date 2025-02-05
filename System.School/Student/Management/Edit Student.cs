public class EditAluno
{
    public static void EditarAlunos()
    {
        Aluno aluno = new Aluno();
        GNotas notas = new GNotas();
        GInformações info = new GInformações();

        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para editar.");
            return;
        }

        Console.Write("\n===== Edição de Alunos ======");
        Console.Write("\nDigite a matrícula do aluno: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\nNúmero inválido!");
            Console.Write("\nInforme uma matrícula válida: ");
        }

        aluno = CAluno.listaAlunos.Find(a => a.Matricula == matricula);

        if (aluno == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        Console.Write($"\n Aluno encontrado: {aluno.Nome}");
        Console.WriteLine("\n 1. Informações do Aluno");
        Console.WriteLine(" 2. Notas do Aluno");
        Console.Write("\n O que deseja alterar: ");
        int edit = int.Parse(Console.ReadLine());

        switch (edit)
        {
            case 1:
                info.Info();
                break;
            case 2:
                GNotas.Nota(aluno);
                break;
        }
    }
}