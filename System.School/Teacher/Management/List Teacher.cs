public class ListProfessor()
{
    public static void ListarProfessores()
    {
        if (CadProfessor.listaProfessores.Count == 0)
        {
            Console.WriteLine("\n Não há professores cadastrados.\n");
            return;
        }
        else
        {
            Console.WriteLine("\n===== Lista de Professores ======");
            foreach (Professor professor in CadProfessor.listaProfessores)
            {
                Console.WriteLine($"Nome: {professor.Nome}");
                Console.WriteLine($"Matrícula: {professor.Matricula}");
                Console.WriteLine($"Carga Horária: {professor.Horario} horas");
            }
        }
    }
}