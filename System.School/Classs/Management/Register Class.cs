using System.Net;

public class CTurma
{
    public static List<Turma> listaTurmas = new List<Turma>();
    public static void CadastrarTurmas()
    {
        Turma turma = new Turma();
        Console.WriteLine("\n====== Cadastrar Turma ======");
        Console.Write("Nome da Turma: ");
        turma.Nome = Console.ReadLine();

        listaTurmas.Add(turma);
    }
}