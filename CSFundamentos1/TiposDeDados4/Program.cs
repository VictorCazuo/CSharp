Console.WriteLine("Definindo variáveis do tipo string e objecte dynamic");
Console.WriteLine();

string nome = "Curso C#"; // string é imutável, ou seja, se eu criar ou alterar uma string, na verdade estou criando uma nova string na memória
String titulo = "Curso C# Essencial"; // se eu precisar ficar alterando o valor de uma string, é melhor usar o StringBuilder


//estes mesmos exemplos com object, poderiam ser feitos com dynamic
object nota = 10; 
object nota2 = 9.5m;
object nomeAluno = "André";
object ativo = true;
object letra = 'A';

Console.WriteLine(nome);
Console.WriteLine(titulo);
Console.WriteLine(nota);
Console.WriteLine(nota2);
Console.WriteLine(nomeAluno);
Console.WriteLine(ativo);
Console.WriteLine(letra);

Console.ReadLine();