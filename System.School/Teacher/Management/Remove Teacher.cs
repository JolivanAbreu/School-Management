using System.Reflection.Metadata;

public class RemProfessor
{
    public static void RemoverProfessores()
    {
        if (CProfessor.listaProfessores.Count == 0)
        {
            Console.WriteLine("\n❌ Nenhum professor cadastrado para remoção.");
            return;
        }

        Console.WriteLine("\n===== 🗑️ Exclusão de Professores =====");
        Console.Write("🔢 Digite a matrícula do professor: ");
        int matricula;

        while (!int.TryParse(Console.ReadLine(), out matricula))
        {
            Console.WriteLine("\n⚠️ Número inválido! Informe uma matrícula válida: ");
        }
        
        Professor professor = CProfessor.listaProfessores.Find(p => p.Matricula == matricula);

        if (professor == null)
        {
            Console.WriteLine("\n❌ Matrícula não encontrada.");
            return;
        }

        CProfessor.listaProfessores.Remove(professor);
        Console.WriteLine("\n✅ Professor removido com sucesso!");
    }
}