//Exercícios fase 1

//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.

using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

int idade = 35;
Console.WriteLine($"A idade é: {idade} anos");


//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.

string nome = "Maria";
Console.WriteLine($"O nome é {nome}.");

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine($"O valor da altura é: {altura}");

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine($"A data é: {data.ToShortDateString()}");

//5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;

const int ano = 12;
Console.WriteLine($"O ano é: {ano}");


//6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o 
//valor 7.80 e exiba o seu valor.

double? nota = 7.80d;
Console.WriteLine($"A nota é: {nota}");

//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?

/*
Tipos por valor = São tipos guardados na memória Stack (memória rápida e organizada), eles são variáveis que guardam o valor independente
ou seja, se eu crio uma variável a = 10 e faço b = a, eu estou criando uma cópia de a, se eu mudar o valor de b, a variável "a" 
fica intacta. (int, bool, double, char)

Tipos por referência = São tipos guardados na memória Heap (memória grande e desorganizada), a variável guarda o endereço e não uma
cópia, ou seja, se você criar uma variável a = 10 e b = a, mudar o valor de b = 20, o valor de a é alterado também. (class, interface, string)
*/

//8 - Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//( int )  x = 10;
//(bouble ) numero = 7.99;
//( char )  letra = 'C';
//( float )  temperatura = 27.4f;
//( bool )  ativo = false;
//( string )  nome = "Manoel";
//( decimal )  salario = 950.99m;
//( DateTime )  hoje = DateTime.Now


//9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
//referência (R) 
//( V )  int n = 1; 
//( R )  string titulo = "A vida";
//( V )  float f = 12.45f;
//( V )  double d = 5.45;
//( V )  decimal valor = 10.99m
//( V )  char sexo = ‘M’;
//( R )  object o = null;

//10 - O que é um nullable type e qual a sua utilidade ?
/*
Nullable type permite que uma variável ou constante tenha o valor null junto com seus valores padrões, ou seja, bool tem o valor
(False, True e null). Ele é usado quando não sabemos ou não temos valor a uma variável, a variável está vazia. Ele pode ser 
representado de duas formas = Nullable <int> num = null OU int? num = null e para comparar variáveis eu posso usar o ??, que se o
valor comparado for null ele usa o valor que vem depois da ??, mas se ele tiver valor, usa o valor da variável.
 */


//11- O que é Camel Case ? Dê um exemplo de sua aplicação.
/*
 Camel case é uma convenção onde a primeira letra da palavra é minuscula e as demais começam com maiuscula. Elas são utilizadas
em nomes de variáveis, parâmetros e campos. calculoDaParcela
 */

//12- O que é Pascal Case ? Dê um exemplo de sua aplicação
/*
Pascal case é uma convenção onde toda a primeira letra das palavras começam com letra maiuscula. Utilizadas em classes, interfaces,
métodos e propriedades.
*/

//13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
//seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
//operação de soma)

int x = 77, y = 66;

Console.WriteLine($"{x} + {y} = {x + y}");

//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e 
//string

/*
    bool = False
    char = '\0'  ou (U+000)
    int = 0
    double = 0d
    float = 0.0f
    decimal = 0m
    string = null
*/

//15 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis 
//considerando a nomenclatura usada:
//(F) double 1valor = 12.45; 
//(F) string #nome = "Pedro";    
//(V) float _temperatura = 12.45f;  
//(F) double int = 5;  
//(F) decimal renda extra = 91.45m;
//(F) bool status$conta = false;
//(V) string titulo3 = “Tópico 1”; 
//(V) float salario_mensal = 1999.55f;
//(V) int percentualValorDesconto = 5;
//(V) const bool MENSALIDADE_EM_DIA = true;

 
