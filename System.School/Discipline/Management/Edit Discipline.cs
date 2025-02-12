public class EditDisciplina
{
    public static void EditarDisciplina()
    {
        Disciplina disciplina = new Disciplina();

        if (CDisciplina.listaDisciplina.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum aluno cadastrado para edição.");
            return;
        }

        Console.WriteLine("\n===== ��️ Edição de Disciplinas =====");
        Console.Write("🔢 Digite o código da disciplina: ");
        int codigo;

        while (!int.TryParse(Console.ReadLine(), out codigo))
        {
            Console.Write("\n⚠️ Número inválido! Informe uma matrícula válida: ");
        }

        disciplina = CDisciplina.listaDisciplina.Find(d => d.Codigo == codigo);

        if (disciplina == null)
        {
            Console.WriteLine("\n❌ Disciplina não encontrada.");
            return;
        }

        Console.Write($"\n✅ Disciplina encontrado: {disciplina.Nome}\n");
        Console.WriteLine("1️⃣ Informações do Disciplina");
        Console.Write("📌 Escolha a opção que deseja alterar: ");
        int edit = int.Parse(Console.ReadLine());

        switch (edit)
        {
            case 1:
                DInformações.Info(disciplina);
                break;
        }
    }
}