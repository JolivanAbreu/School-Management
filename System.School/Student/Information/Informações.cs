public class GInformações()
{
    public static void Info(Aluno aluno)
    {
        Console.WriteLine("\n===== ℹ️ Atualização de Informações =====");
        Console.WriteLine("1️⃣ Nome");
        Console.WriteLine("2️⃣ Idade");
        Console.Write("📌 Escolha uma opção: ");
        int opcaoInfo = int.Parse(Console.ReadLine());

        switch (opcaoInfo)
        {
            case 1:
                Console.Write("📝 Informe o novo nome: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("\n✅ Nome atualizado com sucesso!");
                break;
            case 2:
                Console.Write("📝 Informe a nova idade: ");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("\n✅ Idade atualizada com sucesso!");
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida.");
                break;
        }
    }
}