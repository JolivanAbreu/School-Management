using System.Diagnostics.Contracts;

public class RemTurma
{
    public static void RemoverTurmas()
    {
        if (CTurma.listaTurmas.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhuma turma cadastrada para remoção.");
            return;
        }

        Console.WriteLine("\n===== 🗑️ Exclusão de Turmas =====");
        Console.Write("🔢 Digite o número da turma: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("\n⚠️ Número inválido! Informe um número válido: ");
        }

        Turma turma = CTurma.listaTurmas.Find(t => t.Numero == numero);

        if (turma == null)
        {
            Console.WriteLine("\n❌ Turma não encontrada.");
            return;
        }

        CTurma.listaTurmas.Remove(turma);
        Console.WriteLine("\n✅ Turma removida com sucesso!");
    }
}