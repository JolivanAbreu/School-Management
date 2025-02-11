class Turmas()
{
    public static void GerTurmas()
    {
        while (true)
        {
            Console.WriteLine("\n========== GERENCIAMENTO DE TURMAS ==========");
            Console.WriteLine("[1] Cadastrar Turma");
            Console.WriteLine("[2] Listar Turmas");
            Console.WriteLine("[3] Editar Turma");
            Console.WriteLine("[4] Remover Turma");
            Console.WriteLine("[5] Voltar ao Menu Principal");
            Console.Write("\nEscolha uma opção: ");
            int OptionTur;

            if (!int.TryParse(Console.ReadLine(), out OptionTur))
            {
                Console.WriteLine("\n❌ Opção inválida! Tente novamente.");
                continue;
            }

            Action acao = OptionTur switch
            {
                1 => CTurma.CadastrarTurmas,
                2 => ListaTurma.ListarTurmas,
                3 => EditTurma.EditarTurma,
                4 => RemTurma.RemoverTurmas,
                5 => () =>
                {
                    Console.WriteLine("\n🔙 Retornando ao menu principal...");
                    return;
                }
                ,
                _ => () => Console.WriteLine("\n❌ Opção inválida! Tente novamente.")
            };

            acao();

            if(OptionTur == 5) return;
        }
    }

    private static void CadastrarTurmas()
    {
        CTurma cTurma = new CTurma();
        CTurma.CadastrarTurmas();
    }

    private static void ListarTurmas()
    {
        ListaTurma listarTurmas = new ListaTurma();
        ListaTurma.ListarTurmas();

    }

    public static void EditarTurmas()
    {
        EditTurma editTurma = new EditTurma();
        EditTurma.EditarTurma();
    }

    public static void RemoverTurmas()
    {
        RemTurma remTurma = new RemTurma();
        RemTurma.RemoverTurmas();
    }
}
