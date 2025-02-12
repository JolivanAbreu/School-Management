public class EditProfessor
{
    public static void EditarProfessor()
    {
        Professor professor = new Professor();
        InfoProfessor infoProfessor  = new InfoProfessor();
        
        if (CProfessor.listaProfessores.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum professor cadastrado para edição.");
            return;
        }

        Console.WriteLine("\n===== ✏️ Edição de Professores =====");
        Console.Write("🔢 Digite a matrícula do professor: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.Write("\n⚠️ Número inválido! Informe uma matrícula válida: ");
        }

        professor = CProfessor.listaProfessores.Find(p => p.Matricula == matricula);

        if (professor == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        Console.Write($"\n✅ Professor encontrado: {professor.Nome}\n");
        Console.WriteLine("1️⃣ Informações do Professor");
        Console.Write("📌 Escolha a opção que deseja alterar: ");
        int edit = int.Parse(Console.ReadLine());

        if (edit == 1)
        {
            InfoProfessor.InfoProf(professor);
        }
    }
}