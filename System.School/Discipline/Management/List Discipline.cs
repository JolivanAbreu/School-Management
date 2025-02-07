public class ListaDisciplina
{
    public static void ListarDisciplina()
    {
        if (CDisciplina.listaDisciplina.Count == 0)
        {
            Console.WriteLine("\n Não há disciplinas cadastradas.\n");
            return;
        }
        else
        {
            Console.WriteLine("\n===== Lista de Disciplinas ======");
            foreach (var disciplina in CDisciplina.listaDisciplina)
            {
                Console.WriteLine($"\n Nome: {disciplina.Nome}");
            }
        }
    }
}