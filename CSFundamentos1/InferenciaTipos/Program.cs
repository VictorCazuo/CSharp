Console.WriteLine("Inferência de Tipos");

//int idade = 25;
//string nome = "Maria";
//decimal salario = 2500.00m;

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} e ganha {salario.ToString("c")}");

//coisas erradas

var salario = null;
var titulo;
var salario, titulo, imposto;

//não posso mudar o tipo
var num = 10;
num = num + 20;
num = "30";