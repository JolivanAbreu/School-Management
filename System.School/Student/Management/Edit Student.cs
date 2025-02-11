public class EditAluno
{
    public static void EditarAlunos()
    {
        Aluno aluno = new Aluno();
        GNotas notas = new GNotas();
        GInformações info = new GInformações();

        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para edição.");
            return;
        }

        Console.WriteLine("\n===== ✏️ Edição de Alunos =====");
        Console.Write("🔢 Digite a matrícula do aluno: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\n⚠️ Número inválido! Informe uma matrícula válida: ");
        }

        aluno = CAluno.listaAlunos.Find(a => a.Matricula == matricula);

        if (aluno == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        Console.Write($"\n✅ Aluno encontrado: {aluno.Nome}\n");
        Console.WriteLine("1️⃣ Informações do Aluno");
        Console.WriteLine("2️⃣ Notas do Aluno");
        Console.Write("📌 Escolha a opção que deseja alterar: ");
        int edit = int.Parse(Console.ReadLine());

        switch (edit)
        {
            case 1:
                GInformações.Info(aluno);
                break;
            case 2:
                GNotas.Nota(aluno);
                break;
        }
    }
}