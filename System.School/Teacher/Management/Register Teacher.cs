public class CadProfessor
{
    public static List<Professor> listaProfessores = new List<Professor>();
    public static void CadastrarProfessores()
    {
        Professor professor = new Professor();

        Console.WriteLine("\n====== Cadastrar Professor ======");

        professor.Matricula = professor.GerarMatricula();
        Console.Write($"\n Matrícula: {professor.Matricula}");

        Console.Write("\n Nome: ");
        professor.Nome = Console.ReadLine();

        Console.Write(" Horario: ");
        professor.Horario = int.Parse(Console.ReadLine());

        listaProfessores.Add(professor);

        Console.Write("\n✅ Cadastro realizado com sucesso!\n");

        return;
                
    }
}