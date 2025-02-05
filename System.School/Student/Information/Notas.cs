using System.Security.Cryptography.X509Certificates;

public class GNotas
{
    public static void Nota(Aluno aluno)
    {
        Console.WriteLine("\n Notas");
        Console.Write("\n 1. Nota 1");
        Console.Write("\n 2. Nota 2");
        Console.Write("\n 3. Nota 3");
        Console.Write("\n Escolha uma opção: ");
        int opcaoNota = int.Parse(Console.ReadLine());

        switch (opcaoNota)
        {
            case 1:
                Console.Write("\nInforme a nova nota 1: ");
                double novaNota1 = double.Parse(Console.ReadLine());
                aluno.Nota1 = novaNota1;
                break;
            case 2:
                Console.Write("\nInforme a nova nota 2: ");
                double novaNota2 = double.Parse(Console.ReadLine());
                aluno.Nota2 = novaNota2;
                break;
            case 3:
                Console.Write("\nInforme a nova nota 3: ");
                double notaNota3 = double.Parse(Console.ReadLine());
                aluno.Nota3 = notaNota3;
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida.");
                return ;
        }

        Console.WriteLine("\n✅ Alterado com sucesso!");

    }
}