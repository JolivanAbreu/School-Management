class Alunos()
{
    public static void GerAlunos()
    {
        while (true)
        {
            Console.WriteLine("\n====== Gerenciamento de Alunos ======");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Listar Alunos");
            Console.WriteLine("3. Editar Aluno");
            Console.WriteLine("4. Remover Aluno");
            Console.WriteLine("5. Voltar");

            Console.Write("Informe uma opção: ");
            int OptionAl;


            if (!int.TryParse(Console.ReadLine(), out OptionAl))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionAl switch
            {
                1 => CAluno.CadastrarAlunos,
                2 => ListAluno.ListarAlunos,
                3 => EditAluno.EditarAlunos,
                4 => RemAluno.RemoverAlunos,
                5 => () =>
                {
                    Console.WriteLine("\nVoltando ao menu principal...");
                    return; // Sai do programa
                }
                ,
                _ => () => Console.WriteLine("Opção inválida. Tente novamente.")
            };

            acao();

            if (OptionAl == 5) return;
        }

    }

    private static void Cadastro()
    {
        CAluno cAluno = new CAluno();
        CAluno.CadastrarAlunos();
    }
    private static void ListarAlunos()
    {
        ListAluno listAluno = new ListAluno();
        ListAluno.ListarAlunos();
    }

    private static void RemoverAluno()
    {
        RemAluno remAluno = new RemAluno();
        RemAluno.RemoverAlunos();
    }

    private static void EditarAluno()
    {
        EditAluno editAluno = new EditAluno();
        EditAluno.EditarAlunos();
    }


}