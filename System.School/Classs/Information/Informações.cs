public class GInforTurma()
{
    public static void InfoTurmaProfessor(Turma turma)
    {
        Console.WriteLine("\nProfessores");
        Console.WriteLine("\nProfessores disponíveis:");
        for (int i = 0; i < CadProfessor.listaProfessores.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {CadProfessor.listaProfessores[i].Nome} (Matrícula: {CadProfessor.listaProfessores[i].Matricula})");
        }

        Console.Write("\nEscolha o número do professor: ");
        int escolhaProfessor = int.Parse(Console.ReadLine()) - 1;

        if (escolhaProfessor < 0 || escolhaProfessor >= CadProfessor.listaProfessores.Count)
        {
            Console.WriteLine("\n⚠️ Escolha inválida.");
            return;
        }

        turma.Professor = CadProfessor.listaProfessores[escolhaProfessor];
    }

    public static void InfoTurmaDisciplina(Turma turma)
    {
        Console.WriteLine("\nDisciplinas");
    }
}