public class GInformações()
{
    public static void Info(Aluno aluno)
    {
        Console.WriteLine("\n Informações");
        Console.Write(" 1. Nome");
        Console.Write("\n 2. Idade");
        Console.Write("\n Escolha uma opção: ");
        int opcaoInfo = int.Parse(Console.ReadLine());

        if (opcaoInfo == 1)
        {
            Console.Write("Informe o novo nome: ");
            string novoNome = Console.ReadLine();

            aluno.Nome = novoNome;
            Console.WriteLine("\n✅ Alterado com sucesso!");
        }
        else if (opcaoInfo == 2)
        {
            Console.Write("Informe a nova idade: ");
            int novaIdade = int.Parse(Console.ReadLine());
            aluno.Idade = novaIdade;
            Console.WriteLine("\n✅ Alterado com sucesso!");
        }
    }
}