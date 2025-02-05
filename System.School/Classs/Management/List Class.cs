public class ListaTurma
{
    public static void ListarTurmas()
    {
        if (CTurma.listaTurmas.Count == 0)
        {
            Console.WriteLine("\n Não há turmas cadastradas.\n");
            return;
        }
        else
        {
            Console.WriteLine("\n===== Lista de Turmas ======");
            foreach (var turma in CTurma.listaTurmas)
            {
                Console.WriteLine($"Nome: {turma.Nome}");
            }
        }
    }
}