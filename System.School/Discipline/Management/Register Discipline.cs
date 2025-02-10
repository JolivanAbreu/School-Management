using System;
using System.Collections.Generic;

public class CDisciplina
{
    public static List<Disciplina> listaDisciplina = new List<Disciplina>();

    public static void CadastrarDisciplina()
    {
        Disciplina disciplina = new Disciplina();
        Console.WriteLine("\n====== Cadastrar Disciplina ======");

        disciplina.Codigo = disciplina.GerarMatricula();
        Console.WriteLine($"Código da Disciplina: {disciplina.Codigo}");

        Console.Write("Nome da Disciplina: ");
        disciplina.Nome = Console.ReadLine();

        listaDisciplina.Add(disciplina);

        Console.WriteLine("\n✅ Cadastro realizado com sucesso!\n");
    }
}
