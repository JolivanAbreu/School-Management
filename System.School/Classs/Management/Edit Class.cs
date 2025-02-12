public class EditTurma
{
    public static void EditarTurma()
    {
        Turma turma = new Turma();

        if (CTurma.listaTurmas.Count == 0)
        {
            Console.WriteLine("\n Não há turmas cadastradas.\n");
            return;
        }

        Console.Write("\n===== Edição de Turma ======");
        Console.Write("\nInforme o ID da turma: ");
        int id;

        while (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.Write("\nNúmero inválido!");
            Console.Write("\nInforme um ID válido: ");
        }

        turma = CTurma.listaTurmas.Find(t => t.Numero == id);

        if (turma == null)
        {
            Console.WriteLine("\n�� Turma não encontrada.");
            return;
        }

        Console.Write($"\nTurma encontrada: {turma.Nome}");
        Console.WriteLine("\n1. Nome da turma");
        Console.WriteLine(" 2. Professores");
        Console.WriteLine(" 3. Disciplinas");
        Console.Write("\n O que deseja alterar: ");
        int opcaoEdicao = int.Parse(Console.ReadLine());

        switch (opcaoEdicao)
        {
            case 1:
                Console.Write("\n Novo nome da turma: ");
                turma.Nome = Console.ReadLine();
                break;

            case 2:
                GInforTurma.InfoTurma(turma);
                break;
            case 3:
                GInforTurma.InfoTurmaDisciplina(turma);
                break;
        }

    }
}