//1) Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Digite 3 números inteiros e te devolverei o maior: \n");

Console.WriteLine("Digite o primeiro número: \n");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: \n");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: \n");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"{num1}, o primeiro número, é maior");
}
else if (num2 > num3)
{
    Console.WriteLine($"{num2}, o segundo número é maior");
}
else if (num1 == num2 && num2 == num3)
{
    Console.WriteLine($"Todos são iguais");
}
else
{
    Console.WriteLine($"{num3}, o terceiro número é maior");
}

//2) Escreva um programa para calcular a raiz da equação quadrática :
//-Para calcular as raízes use a fórmula de Báskara : onde
//- Considere a, b e c números inteiros (positivos, negativos e o zero)
//- Solicite a entrada de a , b e c e informe se existe ou não raiz real 

Console.WriteLine("Cálculo da raiz quadrática\n");

Console.WriteLine("Digite o valor de a: \n");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de b: \n");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de c: \n");
int c = Convert.ToInt32(Console.ReadLine());

int delta = (int)Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"\nDelta: {delta}");

if (delta > 0)
{
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine("Duas raízes reais e distintas.");
    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}
else if (delta == 0)
{
    double x = -b / (2.0 * a);
    Console.WriteLine("Uma única raiz real (ou duas raízes iguais).");
    Console.WriteLine($"x = {x}");
}
else
{
    Console.WriteLine("Nenhuma raiz real");
}


//3) Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
//while, do-while e for

//while: 
int contador = 1;
int soma = 0;

while (contador <= 10)
{
    Console.Write(contador);
    soma += contador;
    contador++;

    if (contador < 11)
    {
        Console.Write(" + ");
    }
}

Console.WriteLine($" = {soma}");

//for
int soma = 0;

for (int i = 1; i <= 10; i++)
{
    soma += i;
    Console.Write(i);

    if (i <= 9)
    {
        Console.Write(" + ");
    }
}

Console.WriteLine($" = {soma}");

//do-while

int contador = 1;
int soma = 0;

do
{
    Console.Write(contador);
    soma += contador;
    contador++;

    if (contador <= 10)
    {
        Console.Write(" + ");
    }
} while (contador <= 10);

Console.WriteLine($" = {soma}");

//4) Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero
//recebido via teclado
//- Verifique se o número é maior que zero e emita uma mensagem
//- Considere a tabela de multiplicação de 1 até 10
//- Após exibir a tabela torne a solicitar outro número
//- Para sair do loop defina uma condição de saída

while (true)
{
    Console.WriteLine("Digite um número e te darei sua tabuada: \nDigite -1 para sair.\n");

    int tabuada = Convert.ToInt32(Console.ReadLine());

    if (tabuada == -1)
    {
        Console.WriteLine("Encerrando o programa.\nTchau...");
        break;
    }
    else if (tabuada <= 0)
    {
        Console.WriteLine("Digite um valor maior que 0\n");
        continue;
    }
    else
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
        }
    }
}

//5)5 - Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de
//resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//Não utilize a instrução break.
//Qual a instrução para sair de um loop ?
//a.quit
//b.continue
//c.break
//d.exit
//Qual a opção correta ? (Tecle x para sair)
//Abaixo um modelo de saida esperado :

Console.WriteLine("Bem vindo ao questionário!!\nResponda a seguinte questão:\nQual a instrução para sair de um loop ?\na.quit\nb.continue\nc.break\nd.exit\nQual a opção correta ? [Tecle x para sair]");

string resposta = "";

while (resposta != "x")
{
    Console.WriteLine("Escolha uma opção:\n");
    resposta = Console.ReadLine().ToLower();

    if (resposta == "a")
    {
        Console.WriteLine("Resposta Incorreta");
    }
    else if (resposta == "b")
    {
        Console.WriteLine("Resposta Incorreta");
    }
    else if (resposta == "c")
    {
        Console.WriteLine("Reposta Correta");
    }
    else if (resposta == "d")
    {
        Console.WriteLine("Resposta Incorreta");
    }
    else
    {
        if (resposta == "x")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Digite uma alternativa correta!!");
        }

    }
}

Console.WriteLine("Saindo...");

//6) Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3
//maneiras diferentes:
//-Incrementando 2 em cada passo

for (int i = 10; i <= 20; i += 2)
{
    if (i == 16)
    {
        continue;
    }
    Console.WriteLine(i);
}

//- Incrementando 1 em cada passo

for (int i = 10; i <= 20; i++)
{

    if (i % 2 != 0)
    {
        continue;
    }

    if (i == 16)
    {
        continue;
    }
    Console.WriteLine(i);
}

//- Com e loop infinito (use "break" e "continue")

int i = 10;

while (true)
{
    if (i == 16)
    {
        i += 2;
        continue;
    }
    Console.WriteLine(i);
    i += 2;

    if (i == 20)
    {
        Console.WriteLine(i);
        break;
    }
}

//7 - Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:
//*
//**
//***
//****

for (int coluna = 0; coluna <= 3; coluna++)
{
    for (int linha = 1; linha <= coluna; linha++)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}

//8)  Escreva um programa para calcular o fatorial de um número inteiro.
//O fatorial de um número é representado por : n! => n * (n – 1) *(n – 2) ....2 * 1
//Exemplo: fatorial de 6 é representado por 6! = 6*5*4*3*2*1

Console.WriteLine("Digite um número inteiro e te darei o fatorial: \n");
int fatorial = Convert.ToInt32(Console.ReadLine());
int calculo = 1;

for (; fatorial >= 1; fatorial--)
{
    Console.Write($"{fatorial}");
    calculo *= fatorial;

    if (fatorial > 1)
    {
        Console.Write(" * ");
    }
}

Console.WriteLine($" = {calculo}");

//9) Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado
int iterador = 1;
int tabuada = 2;

do
{
    do
    {
        Console.WriteLine($"{tabuada} X {iterador} = {tabuada * iterador}");
        iterador++;
    } while (iterador <= 10);

    Console.WriteLine(" ");
    tabuada++;
    iterador = 1;

} while (tabuada <= 6);

//10) Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de
//um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a
//instrução switch, break e default em um loop infinito e defina uma condição de saida

while (true)
{
    Console.WriteLine("Digite a nota do aluno de 0 a 10: \nPara sair digite -1\n");
    float nota = Convert.ToSingle(Console.ReadLine());

    if (nota == -1)
    {
        Console.WriteLine("tchau..");
        break;
    }
    switch (nota)
    {
        case >= 0 and <= 4:
            Console.WriteLine("F");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case >= 7 and <= 8:
            Console.WriteLine("B");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 10:
            Console.WriteLine("A+");
            break;
        default:
            Console.WriteLine("Digite uma nota válida");
            break;

    }
}

//11) Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números
//inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e
//quando isso ocorrer exibir uma mensagem de alerta)

Console.WriteLine("Bem vindo a calculadora!!\n");

while (true)
{
    Console.WriteLine("Digite o primeiro número: \n");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o operando (+, -, /, *): \n");
    string operando = Console.ReadLine();

    Console.WriteLine("Digite o segundo número: \n");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (operando == "/" && num2 == 0)
    {
        Console.WriteLine("Não existe divisão por 0");
        continue;
    }

    if (operando == "+")
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }
    else if (operando == "-")
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }
    else if (operando == "*")
    {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
    }
    else if (operando == "/")
    {
        Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
    }
    else
    {
        Console.WriteLine("Digite um operando válido");
    }
}