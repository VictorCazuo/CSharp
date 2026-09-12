 using list_exercicio;

List<Aluno> alunos = FonteDados.GetAlunos();

alunos[0].ExibirDados(alunos);

alunos.Add(new Aluno("Bia", 7.75 ));
alunos.Add(new Aluno("Mario", 8.95 ));

alunos[0].ExibirDados(alunos);

Aluno? encontrarAluno = alunos.Find(a => a.Nome == "Amanda");
if (encontrarAluno != null)
{
    alunos.Remove(encontrarAluno);
}

alunos[0].ExibirDados(alunos);

alunos.Sort((aluno1, aluno2) => aluno1.Nome.CompareTo(aluno2.Nome));
alunos[0].ExibirDados(alunos);

var encontrarNota = alunos.FindAll(n => n.Nota >= 8);
foreach(var nota in encontrarNota)
{
   Console.WriteLine($"notas maiores ou iguais à 8 = {nota.Nota}");
}