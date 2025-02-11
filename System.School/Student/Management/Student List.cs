public class ListAluno
{
    public static void ListarAlunos()
    {
        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n⚠️ Não há alunos cadastrados no sistema.\n");
            return;
        }
        else
        {
            Console.WriteLine("\n===== 📜 Lista de Alunos =====");
            foreach (var aluno in CAluno.listaAlunos)
            {
                Console.WriteLine($"\n📌 Matrícula: {aluno.Matricula} \n👤 Nome: {aluno.Nome} \n🎂 Idade: {aluno.Idade} \n📊 Nota 1: {aluno.Nota1} \n📊 Nota 2: {aluno.Nota2} \n📊 Nota 3: {aluno.Nota3}");
            }
        }
    }
}