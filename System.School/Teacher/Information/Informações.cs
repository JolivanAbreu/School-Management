public class InfoProfessor()
{
    public static void InfoProf(Professor professor)
    {
        Console.WriteLine("\n===== ℹ️ Atualização de Informações =====");
        Console.WriteLine("1️⃣ Nome");
        Console.WriteLine("2️⃣ Horario");
        Console.Write("📌 Escolha uma opção: ");
        int opcaoInfo = int.Parse(Console.ReadLine());

        switch (opcaoInfo)
        {
            case 1:
                Console.Write("📝 Informe o novo nome: "); 
                professor.Nome = Console.ReadLine();
                Console.WriteLine("\n✅ Nome atualizado com sucesso!");
                break;
            case 2:
                Console.Write("📝 Informe o novo horario: ");
                professor.Horario = int.Parse(Console.ReadLine());
                Console.WriteLine("\n✅ Horário atualizado com sucesso!");
                break;
        }

    }
}