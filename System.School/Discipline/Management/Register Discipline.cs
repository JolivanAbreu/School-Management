public class CDisciplina
{
    public static List<Disciplina> listaDisciplina = new List<Disciplina>();
    public static void CadastrarDisciplina()
    {
        Disciplina disciplina = new Disciplina();
        Console.WriteLine("\n====== Cadastrar Disciplina ======");
        disciplina.Codigo = disciplina.GerarMatricula();
        Console.Write($"Código da Disciplina: {disciplina.Codigo}");
        Console.Write("\nNome da Disciplina: ");
        disciplina.Nome = Console.ReadLine();
        listaDisciplina.Add(disciplina);
        Console.WriteLine("\n✅ Cadastro realizado com sucesso!\n");
        return;
    }
}