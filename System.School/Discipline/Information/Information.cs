public class DInformações()
{
    public static void Info(Disciplina disciplina)
    {
        Console.WriteLine("\n===== ℹ️ Atualização de Informações =====");
        Console.WriteLine("1️⃣ Nome");
        Console.Write("📌 Escolha uma opção: ");
        int opcaoInfo = int.Parse(Console.ReadLine());

        switch (opcaoInfo)
        {
            case 1:
                Console.Write("📝 Informe o novo nome: ");
                disciplina.Nome = Console.ReadLine();
                Console.WriteLine("\n✅ Nome atualizado com sucesso!");
                break;
        }
    }
}