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
                Console.WriteLine("❌ Opção inválida. Tente novamente.");
                continue;
            }

            Action acao = OptionProf switch
            {
                1 => CProfessor.CadastrarProfessores,
                2 => ListProfessor.ListarProfessores,
                3 => EditProfessor.EditarProfessor,
                4 => RemProfessor.RemoverProfessores,
                5 => () =>
                {
                    Console.WriteLine("\n🔙 Voltando ao menu principal...");
                    return;
                }
                ,
                _ => () => Console.WriteLine("❌ Opção inválida. Tente novamente.")
            };

            acao();

            if (OptionProf == 5) return;
        }
    }


    private static void GerProfessores()
    {
        CProfessor cadProfessore = new CProfessor();
        CProfessor.CadastrarProfessores();
    }

    private static void ListProfessores()
    {
        ListProfessor listProfessor = new ListProfessor();
        ListProfessor.ListarProfessores();
    }

    public static void EditarProfessores()
    {
        EditProfessor editProfessor = new EditProfessor();
        EditProfessor.EditarProfessor();
    }

    public static void RemoverProfessores()
    {
        RemProfessor remProfessor = new RemProfessor();
        RemProfessor.RemoverProfessores();
    }
}