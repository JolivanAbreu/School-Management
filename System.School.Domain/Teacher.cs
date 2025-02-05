public class Professor()
{   
    static int contador = 1;
    public int Matricula { get; set; }
    public string Nome { get; set; }
    //public string Disciplina { get; set; }
    //public string Turma { get; set; }
    public int Horario { get; set; }

    public int GerarMatricula()
    {
        string anoAtual = DateTime.Now.Year.ToString();
        string id = contador.ToString("D3"); // Formata com três dígitos (ex: 001, 002)

        contador++;

        return int.Parse($"{anoAtual}{id}"); // Converte a string "2025001" para int
    }

}