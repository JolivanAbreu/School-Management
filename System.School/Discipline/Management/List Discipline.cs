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

            if (disciplina.Professor != null)
            {
                Console.WriteLine($"👨‍🏫 Professor: {disciplina.Professor.Nome} (Matrícula: {disciplina.Professor.Matricula})");
            }
            else
            {
                Console.WriteLine("⚠️ Professor não cadastrado");
            }

            if (disciplina.Alunos != null && disciplina.Alunos.Count > 0)
            {
                Console.Write("👨‍🎓 Alunos:");
                foreach (var aluno in disciplina.Alunos)
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