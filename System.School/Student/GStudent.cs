class Alunos()
{
    public static void GerAlunos()
    {
        while (true)
        {
            Console.WriteLine("\n========== GERENCIAMENTO DE ALUNOS ==========");
            Console.WriteLine("[1] Cadastrar Aluno");
            Console.WriteLine("[2] Listar Alunos");
            Console.WriteLine("[3] Editar Aluno");
            Console.WriteLine("[4] Remover Aluno");
            Console.WriteLine("[5] Voltar ao Menu Principal");
            Console.Write("\nEscolha uma opção: ");
            int OptionAl;


            if (!int.TryParse(Console.ReadLine(), out OptionAl))
            {
                Console.WriteLine("\n❌ Opção inválida! Tente novamente.");
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
                    Console.WriteLine("\n🔙 Retornando ao menu principal...");
                    return;
                }
                ,
                _ => () => Console.WriteLine("\n❌ Opção inválida! Tente novamente.")
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