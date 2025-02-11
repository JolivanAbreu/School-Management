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
        Console.WriteLine("\nDisciplinas disponíveis:");
        for (int i = 0; i < CDisciplina.listaDisciplina.Count; i++)
        {
            Console.WriteLine($"{i + 1} - Nome: {CDisciplina.listaDisciplina[i].Nome}");
        }

        List<Disciplina> disciplinasSelecionados = new List<Disciplina>();
        Console.Write("\nEscolha a disciplina: ");
        string[] escolhaDisciplina = Console.ReadLine().Split(',');

        foreach (string escolha in escolhaDisciplina)
        {
            if (int.TryParse(escolha.Trim(), out int indiceDisciplina) && indiceDisciplina > 0 && indiceDisciplina <= CAluno.listaAlunos.Count)
            {
                disciplinasSelecionados.Add(CDisciplina.listaDisciplina[indiceDisciplina - 1]);
            }
            else
            {
                Console.WriteLine($"⚠️ Número {escolha} inválido. Ignorando...");
            }
        }

    }
}