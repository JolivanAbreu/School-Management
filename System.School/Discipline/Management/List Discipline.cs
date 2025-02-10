public class ListaDisciplina
{
    public static void ListarDisciplina()
    {
        if (CDisciplina.listaDisciplina.Count == 0)
        {
            Console.WriteLine("\n❌ Não há disciplinas cadastradas.\n");
            return;
        }

        Console.WriteLine("\n===== 📋 Lista de Disciplinas ======");
        foreach (var disciplina in CDisciplina.listaDisciplina)
        {
            Console.WriteLine($"\n Matricula da Disciplina: {disciplina.Codigo}");
            Console.WriteLine($"\n📌 Nome da Disciplina: {disciplina.Nome} ");
        }

    }
}