using System;
using System.Collections.Generic;

public class CDisciplina
{
    public static List<Disciplina> listaDisciplina = new List<Disciplina>();

    public static void CadastrarDisciplina()
    {
        Disciplina disciplina = new Disciplina();
        Console.WriteLine("\n====== Cadastrar Disciplina ======");

        // Gerar código único para disciplina
        disciplina.Codigo = disciplina.GerarMatricula();
        Console.WriteLine($"Código da Disciplina: {disciplina.Codigo}");

        Console.Write("Nome da Disciplina: ");
        disciplina.Nome = Console.ReadLine();

        if (CadProfessor.listaProfessores.Count == 0)
        {
            Console.WriteLine("\n⚠️ Nenhum professor cadastrado! Cadastre um professor primeiro.");
            return;
        }

        // Listar professores disponíveis
        Console.WriteLine("\nProfessores disponíveis:");
        for (int i = 0; i < CadProfessor.listaProfessores.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {CadProfessor.listaProfessores[i].Nome} (Matrícula: {CadProfessor.listaProfessores[i].Matricula})");
        }

        Console.Write("\nEscolha o número do professor: ");
        if (!int.TryParse(Console.ReadLine(), out int escolhaProfessor) || escolhaProfessor < 1 || escolhaProfessor > CadProfessor.listaProfessores.Count)
        {
            Console.WriteLine("\n⚠️ Escolha inválida.");
            return;
        }

        disciplina.Professor = CadProfessor.listaProfessores[escolhaProfessor - 1];

        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n⚠️ Nenhum aluno cadastrado! Cadastre alunos primeiro.");
            return;
        }

        // Escolher alunos para a disciplina
        List<Aluno> alunosSelecionados = new List<Aluno>();

        Console.WriteLine("\nAlunos disponíveis:");
        for (int i = 0; i < CAluno.listaAlunos.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {CAluno.listaAlunos[i].Nome} (Matrícula: {CAluno.listaAlunos[i].Matricula})");
        }

        Console.Write("\nDigite os números dos alunos separados por vírgula (ex: 1,3,5): ");
        string[] escolhasAlunos = Console.ReadLine().Split(',');

        foreach (string escolha in escolhasAlunos)
        {
            if (int.TryParse(escolha.Trim(), out int indiceAluno) && indiceAluno > 0 && indiceAluno <= CAluno.listaAlunos.Count)
            {
                Aluno alunoSelecionado = CAluno.listaAlunos[indiceAluno - 1];

                if (!alunosSelecionados.Contains(alunoSelecionado))
                {
                    alunosSelecionados.Add(alunoSelecionado);
                }
                else
                {
                    Console.WriteLine($"⚠️ O aluno {alunoSelecionado.Nome} já foi adicionado.");
                }
            }
            else
            {
                Console.WriteLine($"⚠️ Número {escolha} inválido. Ignorando...");
            }
        }

        disciplina.Alunos = alunosSelecionados;
        listaDisciplina.Add(disciplina);

        Console.WriteLine("\n✅ Cadastro realizado com sucesso!\n");
    }
}
