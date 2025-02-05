using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Professores()
{
    public static void GerProfessor()
    {
        while (true)
        {
            Console.WriteLine("\n====== Gerenciamento de Professores ======");
            Console.WriteLine("1. Cadastrar Professor");
            Console.WriteLine("2. Listar Professor");
            Console.WriteLine("3. Editar Professor");
            Console.WriteLine("4. Remover Professor");
            Console.WriteLine("5. Voltar");

            Console.Write("Informe uma opção: ");
            int OptionProf;


            if (!int.TryParse(Console.ReadLine(), out OptionProf))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionProf switch
            {
                1 => CadProfessor.CadastrarProfessores,
                2 => ListProfessor.ListarProfessores,
                3 => EditAluno.EditarAlunos,
                4 => RemAluno.RemoverAlunos,
                5 => () =>
                {
                    Console.WriteLine("\nVoltando ao menu principal...");
                    Environment.Exit(0); // Sai do programa
                }
                ,
                _ => () => Console.WriteLine("Opção inválida. Tente novamente.")
            };

            acao();
        }

    }

    private static void GerProfessores()
    {
        CadProfessor cadProfessore = new CadProfessor();
        CadProfessor.CadastrarProfessores();
    }

    private static void ListProfessores()
    {
        ListProfessor listProfessor = new ListProfessor();
        ListProfessor.ListarProfessores ();
    }
}