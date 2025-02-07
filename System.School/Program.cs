
class GSE
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("====== Sistema Escolar ======");
            Console.WriteLine("1. Gerenciamento de Alunos");
            Console.WriteLine("2. Gerenciamento de Turmas");
            Console.WriteLine("3. Gerenciamento de Disciplinas");
            Console.WriteLine("4. Gerenciamento de Professores");
            Console.WriteLine("5. Geração de Relatorio");
            Console.WriteLine("6. Sair");

            Console.Write("Escolha uma opção: ");
            int option = int.Parse(Console.ReadLine());

            // Utilizar 


            Action acao = option switch
            {
                1 => GerAlunos,
                2 => GerTurmas,
                3 => GerDisciplina,
                4 => GerProfessore,
                5 => () => { /* Lógica do case 5 */ },
                6 => () =>
                {
                    Console.WriteLine("\n Saindo...");
                    Environment.Exit(0); 
                }
                ,
                _ => () => Console.WriteLine("Opção inválida!")
            };

            acao();
        }
    }


    private static void GerAlunos()
    {
        Alunos alunos = new Alunos();
        Alunos.GerAlunos();
    }

    private static void GerTurmas()
    {
        Turmas turmas = new Turmas();
        Turmas.GerTurmas();
    }

    private static void GerProfessore()
    {
        Professores professores = new Professores();
        Professores.GerProfessor();
    }

    private static void GerDisciplina()
    {
        Disciplinas disciplinas = new Disciplinas();
        Disciplinas.GerDisciplinas();
    }

    /*private static void GerTurmas()
    {
        Turmas turmas = new Turmas();
        Turmas.GerTurmas();
    }*/



}