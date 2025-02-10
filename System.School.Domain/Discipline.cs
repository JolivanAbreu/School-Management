public class Disciplina()
{
    int contador;
    public int Codigo {get; set;}
    public string Nome { get; set; }
    public int GerarMatricula()
    {
        string anoAtual = DateTime.Now.Year.ToString();
        string id = contador.ToString("D3"); // Formata com três dígitos (ex: 001, 002)

        contador++;

        return int.Parse($"{anoAtual}{id}"); // Converte a string "2025001" para int
    }


}