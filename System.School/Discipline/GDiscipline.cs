class Disciplinas()
{
    public static void GerDisciplinas()
    {
        while (true)
        {
            Console.WriteLine("\n====== Gerenciamento de Disciplinas ======");
            Console.WriteLine("1. Cadastrar Disciplina");
            Console.WriteLine("2. Listar Disciplinas");
            Console.WriteLine("3. Editar Disciplina");
            Console.WriteLine("4. Remover Disciplina");
            Console.WriteLine("5. Voltar");

            Console.Write("\n Informe uma opção: ");
            int OptionDis;

            if (!int.TryParse(Console.ReadLine(), out OptionDis))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionDis switch
            {
                1 => CDisciplina.CadastrarDisciplina,
                2 => ListaDisciplina.ListarDisciplina,
                3 => EditAluno.EditarAlunos,
                4 => RemDisciplina.RemoverDisciplina,
                5 => () =>
                {
                    Console.WriteLine("\nVoltando ao menu principal...");
                    return; // Sai do programa
                }
                ,
                _ => () => Console.WriteLine("Opção inválida. Tente novamente.")
            };

            acao();

            if (OptionDis == 5) return;
        }
    }

    public static void Cadastro()
    {
        CDisciplina CadastrarDisciplina = new CDisciplina();
        CDisciplina.CadastrarDisciplina();
    }

    public static void Listar()
    {
        ListaDisciplina ListarDisciplina = new ListaDisciplina();
        ListaDisciplina.ListarDisciplina();
    }


    public static void Editar()
    {
        
    }

    public static void Remover()
    {
      RemDisciplina remDisciplina = new RemDisciplina();
      RemDisciplina.RemoverDisciplina();  
    } 
}