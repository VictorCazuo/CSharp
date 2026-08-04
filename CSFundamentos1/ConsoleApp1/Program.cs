//using Microsoft.VisualBasic;

//Exercícios fase 2
//1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.

//string nome = "Paulo";
//int idade = 17;
//float nota = 7.5f;

//Console.WriteLine($"O Aluno {nome} tem {idade} anos e sua nota é {nota}");


//2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
//escapes.

//Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nNota: {nota}");


//3 - Para qual tipo de dados você pode converter um float implicitamente ?
//( ) int
//(x) double 8 bytes
//( ) long
//(x) decimal 16 bytes

//4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
//( ) int para long
//( x) double para long
//(x ) double para float
//(x ) decimal para float
//(x ) long para int
//( x) double para decimal

//5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
//a concatenação e também a interpolação de strings

//Console.WriteLine("Digite 3 letras:");
//string? letra1 = Console.ReadLine();
//string? letra2 = Console.ReadLine();
//string? letra3 = Console.ReadLine();

//Console.WriteLine(letra3 + letra2 + letra1);
//Console.WriteLine($"letra 3: {letra3}\nletra 2: {letra2}\nletra 1: {letra1}");

//6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//(F) long resultado = 1.32;
//(V) var nome = “Maria”;
//(V) string resultado = 100.ToString();
//(V) A sequência de escape \n inclui uma nova linha
//(F) float f = 5.45;
//(V) decimal valor = (decimal)10.99f;
//(F) var status = null;
//(v) object o = 12.45m;
//(V) string titulo = true.ToString();
//(f) A sequencia \t inclui uma tabulação vertical

//7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
//exibindo o resultado:

//using System.Runtime.Intrinsics.X86;

//Console.WriteLine("Digite 2 números:");
//double valor1 = Convert.ToDouble(Console.ReadLine());
//double valor2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Soma: {valor1 + valor2}");
//Console.WriteLine($"Subtração: {valor1 - valor2}");
//Console.WriteLine($"Multiplicação: {valor1 * valor2}");

//double exponenciacao = Math.Pow(valor1, valor2);
//Console.WriteLine($"Exponenciação {valor1}^{valor2}: {exponenciacao}");

//Console.WriteLine($"Divisão: {valor1 / valor2}");
//Console.WriteLine($"Módulo: {valor1 % valor2}");

//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
//a b e c .

//Valores: a = 1 , b = 12  e c = -13

//int a = 1;
//int b = 12;
//int c = -13;

//double delta = (Math.Pow(b, 2)) - 4 * a * c;
//double x1 = (-b) + Math.Sqrt(delta) / (2 * a);
//double x2 = (-b) - Math.Sqrt(delta) / (2 * a);

//Console.WriteLine(delta);
//Console.WriteLine(x1);
//Console.WriteLine(x2);

//9 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
//Senha é um inteiro. Se o nome for igual a ‘admin’  ou ‘maria’ e a senha for igual a ‘123’ 
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
//inválido’: (use o operador condicional ternário)

//Console.WriteLine("Digite Seu nome:");
//string Nome = Console.ReadLine();

//Console.WriteLine("Digite sua senha em números inteiros: ");
//int Senha = Convert.ToInt32(Console.ReadLine());

//string resultado = (Nome == "admin" || Nome == "maria") && Senha == 123 ? "Login feito com sucesso" : "Login inválido";

//Console.WriteLine(resultado);

//10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando 
//a nomenclatura usada:

//(V) string? nome; é um exemplo de nullable reference type;
//(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//(F) A ordem de precedência dos operadores lógicos é :  ! , || e && (NOT, OR e AND)
//(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
//(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
//(F) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

//11 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

//Console.WriteLine("Digite o valor de x");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite o valor de y");
//int y = Convert.ToInt32(Console.ReadLine());

//string resultadox = x % 2 == 0 ? "x é par" : "x é impar";
//string resultadoy = y % 2 == 0 ? "y é par" : "y é impar";

//Console.WriteLine($"x = {resultadox}\ny = {resultadoy}");

//12 - Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
//console o resultado das seguintes operações :   (x ^ 2->x ao quadrado) (pi = 3.1415)-6 + x * 5
//(13-2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x^2 + x + 10
//pi * x^2

//Console.WriteLine("Digite um número inteiro: ");
//int x = Convert.ToInt32(Console.ReadLine());

//int QUADRADO = (int)Math.Pow(x, 2);
//const float PI = 3.1415f;

//int operacao1 = -6 + (x * 5);
//Console.WriteLine($"-6 + (x * 5) = {operacao1}");

//int operacao2 = (13 - 2) * x;
//Console.WriteLine($"(13-2) * x = {operacao2}");

//int operacao3 = (12 + x) / (x - 4);
//Console.WriteLine($"(12 + x) / (x - 4) = {operacao3}");

//int operacao4 = (3 * QUADRADO) + x + 10;
//Console.WriteLine($"3 x^2 + x + 10 = {operacao4}");

//float operacao5 = PI * QUADRADO;
//Console.WriteLine($"pi * x^2 = {operacao5}");


//int y = 5;
//y = (y++) + y + (++y);
//Console.WriteLine(y);

//14 - Escreva um programa que solicite a temperatura em graus Celsius e converta para 
//Kelvin e Farhenheit usando as fórmulas a seguir:
//-Converter para Kelvin => K = C + 273; 
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;

Console.WriteLine("Digite a temperatura em Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double kelvin = celsius + 273;
double farhenheit = (celsius * 9) / 5 + 32;

Console.WriteLine($"{celsius} grau(s) em kelvin é: {kelvin}");
Console.WriteLine($"{celsius} grau(s) em farhenheit é: {farhenheit}");

//exercio 24, alternativa A












