using System;
using System.Collections.Generic;

public class CTurma
{
    public static List<Turma> listaTurmas = new List<Turma>();

    public static void CadastrarTurmas()
    {
        Turma turma = new Turma();

        Console.WriteLine("\n====== Cadastrar Turma ======");
        Console.Write("Nome da Turma: ");
        turma.Nome = Console.ReadLine();

        // Escolher professor já cadastrado
        if (CadProfessor.listaProfessores.Count == 0)
        {
            Console.WriteLine("\n⚠️ Nenhum professor cadastrado! Cadastre um professor primeiro.");
            return;
        }

        Console.WriteLine("\nProfessores disponíveis:");
        for (int i = 0; i < CadProfessor.listaProfessores.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {CadProfessor.listaProfessores[i].Nome} (Matrícula: {CadProfessor.listaProfessores[i].Matricula})");
        }

        Console.Write("\nEscolha o número do professor: ");
        int escolhaProfessor = int.Parse(Console.ReadLine()) - 1;

        if (escolhaProfessor < 0 || escolhaProfessor >= CadProfessor.listaProfessores.Count)
        {
            Console.WriteLine("\n⚠️ Escolha inválida.");
            return;
        }

        turma.Professor = CadProfessor.listaProfessores[escolhaProfessor];

        // Escolher alunos já cadastrados
        if (CAluno.listaAlunos.Count == 0)
        {
            Console.WriteLine("\n⚠️ Nenhum aluno cadastrado! Cadastre alunos primeiro.");
            return;
        }

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
                alunosSelecionados.Add(CAluno.listaAlunos[indiceAluno - 1]);
            }
            else
            {
                Console.WriteLine($"⚠️ Número {escolha} inválido. Ignorando...");
            }
        }

        // Escolher um Disciplina
        if (CDisciplina.listaDisciplina.Count == 0)
        {
            Console.WriteLine("\n���️ Nenhuma disciplina cadastrada! Cadastre uma disciplina primeiro.");
            return;
        }

        List<Disciplina> disciplinasSelecionados = new List<Disciplina>();
        Console.WriteLine("\nDisciplinas disponíveis:");
        for (int i = 0; i < CDisciplina.listaDisciplina.Count; i++)
        {
            Console.WriteLine($"{i + 1} - Nome: {CDisciplina.listaDisciplina[i].Nome}");
        }

        Console.Write("\nEscolha a disciplina: ");
        string[] escolhaDisciplina = Console.ReadLine().Split(',');

        foreach (string escolha in escolhaDisciplina)
        {
            if (int.TryParse(escolha.Trim(), out int indiceDisciplina) && indiceDisciplina > 0 && indiceDisciplina <= CAluno.listaAlunos.Count)
            {
                disciplinasSelecionados.Add(CDisciplina.listaDisciplina[indiceDisciplina - 1]);
            }
            else
            {
                Console.WriteLine($"⚠️ Número {escolha} inválido. Ignorando...");
            }
        }

        turma.Disciplina = disciplinasSelecionados;
        turma.Alunos = alunosSelecionados;
        listaTurmas.Add(turma);

        Console.WriteLine("\n✅ Turma cadastrada com sucesso!");
    }
}
