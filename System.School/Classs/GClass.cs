class Turmas()
{
    public static void GerTurmas()
    {
        while (true)
        {
            Console.WriteLine("\n====== Gerenciamento de Turmas ======");
            Console.WriteLine("1. Cadastrar Turmas");
            Console.WriteLine("2. Listar Turmas");
            Console.WriteLine("3. Editar Turmas");
            Console.WriteLine("4. Remover Turmas");
            Console.WriteLine("5. Voltar");

            Console.Write("Digite a opção: ");
            int OptionTur;

            if (!int.TryParse(Console.ReadLine(), out OptionTur))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionTur switch
            {
                1 => CTurma.CadastrarTurmas,
                2 => ListaTurma.ListarTurmas,
                3 => EditTurma.EditarTurma,
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
}
