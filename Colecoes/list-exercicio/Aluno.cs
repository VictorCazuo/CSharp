public class Aluno
{
    public string Nome { get; set; } = string.Empty;
    public double Nota { get; set; }

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public void ExibirDados(List<Aluno> alunos)
    {
        double soma = 0;
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Aluno = {aluno.Nome} | Nota = {aluno.Nota}");
            soma += aluno.Nota;

        }


        Console.WriteLine($"A média das notas é = {soma / alunos.Count()} e a quantidade de alunos é = {alunos.Count()}\n");
    }

}
