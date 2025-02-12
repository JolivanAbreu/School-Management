public class RemDisciplina
{
    public static void RemoverDisciplina()
    {
        if (CDisciplina.listaDisciplina.Count == 0)
        {
            Console.WriteLine("\n❌ Não há disciplinas cadastradas.\n");
            return;
        }

        Console.WriteLine("\n===== 🗑️ Exclusão de Disciplinas =====");
        Console.Write("🔢 Digite a código da disciplina: ");
        int código;

        while (!int.TryParse(Console.ReadLine(), out código))
        {
            Console.Write("\n⚠️ Código inválido! Informe um código válido: ");
        }

        Disciplina disciplina = CDisciplina.listaDisciplina.Find(d => d.Codigo == código);

        if (disciplina == null)
        {
            Console.WriteLine("\n❌ Disciplina não encontrada.\n");
            return;
        }
        
        CDisciplina.listaDisciplina.Remove(disciplina);
        Console.WriteLine("\n✅ Disciplina excluída com sucesso!\n");

    }
}