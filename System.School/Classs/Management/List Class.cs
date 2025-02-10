public class ListaTurma
{
    public static void ListarTurmas()
    {
        if (CTurma.listaTurmas.Count == 0)
        {
            Console.WriteLine("\n❌ Não há turmas cadastradas.\n");
            return;
        }

        Console.WriteLine("\n===== 📋 Lista de Turmas ======");
        foreach (var turma in CTurma.listaTurmas)
        {
            Console.WriteLine($"\n📌 Nome da Turma: {turma.Nome}");
            
            // Verifica se a turma tem um professor atribuído
            if (turma.Professor != null)
            {
                Console.WriteLine($"👨‍🏫 Professor: {turma.Professor.Nome} (Matrícula: {turma.Professor.Matricula})");
            }
            else
            {
                Console.WriteLine("⚠️ Professor não atribuído.");
            }

            // Lista de alunos na turma
            if (turma.Alunos != null && turma.Alunos.Count > 0)
            {
                Console.Write("👨‍🎓 Alunos:");
                foreach (var aluno in turma.Alunos)
                {
                    Console.WriteLine($"\n- {aluno.Nome} (Matrícula: {aluno.Matricula})");
                }
            }
            else
            {
                Console.WriteLine("⚠️ Nenhum aluno matriculado nesta turma.");
            }
        }
    }
}
