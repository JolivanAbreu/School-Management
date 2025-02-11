using System.Security.Cryptography.X509Certificates;

public class GNotas
{
    public static void Nota(Aluno aluno)
    {
        Console.WriteLine("\n===== 📊 Atualização de Notas =====");
        Console.WriteLine("1️⃣ Nota 1");
        Console.WriteLine("2️⃣ Nota 2");
        Console.WriteLine("3️⃣ Nota 3");
        Console.Write("📌 Escolha uma opção: ");
        int opcaoNota = int.Parse(Console.ReadLine());

        switch (opcaoNota)
        {
            case 1:
                Console.Write("📝 Informe a nova Nota 1: ");
                double novaNota1 = double.Parse(Console.ReadLine());
                aluno.Nota1 = novaNota1;
                break;
            case 2:
                Console.Write("📝 Informe a nova Nota 2: ");
                double novaNota2 = double.Parse(Console.ReadLine());
                aluno.Nota2 = novaNota2;
                break;
            case 3:
                Console.Write("📝 Informe a nova Nota 3: ");
                double notaNota3 = double.Parse(Console.ReadLine());
                aluno.Nota3 = notaNota3;
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida.");
                return ;
        }

        Console.WriteLine("\n✅ Nota atualizada com sucesso!");
    }
}