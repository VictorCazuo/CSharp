//Console.WriteLine("Digite um número inteiro: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num > 0)
//{
//    Console.WriteLine("O número é positivo");
//}
//else if (num < 0)
//{
//    Console.WriteLine("O número é negativo");
//}
//else if (num == 0)
//{
//    Console.WriteLine("O número é zero");
//}



//Console.WriteLine("Digite um número e direi se é par ou impar:");
//double num = Convert.ToDouble(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("Par");
//}
//else
//{
//    Console.WriteLine("Ímpar");
//}



//Console.WriteLine("Digite uma nota de 0 a 10:");

//double nota = Convert.ToDouble(Console.ReadLine());

//if (nota >= 0 && nota <= 10)
//{
//    if (nota >= 6)
//    {
//        Console.WriteLine($"A nota do aluno é {nota}. Aprovado");
//    }
//    else
//    {
//        Console.WriteLine($"A nota do aluno é {nota}. Reprovado");
//    }
//}
//else
//{
//    Console.WriteLine("Você digitou um número que não está entre 0 e 10");
//}


//Console.WriteLine("Digite sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade < 12 && idade > 0)
//{
//    Console.WriteLine($"Você tem {idade} anos. Você é uma criança");
//}
//else if (idade >= 12 && idade <= 17)
//{
//    Console.WriteLine($"Você tem {idade} anos. Você é um adolescente");
//}
//else if (idade == 18 && idade <= 59)
//{
//    Console.WriteLine($"Você tem {idade} anos. Você é um adulto");
//}
//else if (idade >= 60)
//{
//    Console.WriteLine($"Você tem {idade} anos. Você é um idoso");
//} else
//{
//    Console.WriteLine("Você digitou uma idade negativa ou zero");
//}


//Console.WriteLine("Digite seu login: ");
//var login = Console.ReadLine();

//Console.WriteLine("Digite sua senha: ");
//var senha = Console.ReadLine();

//if (login == "admin" && senha == "1234")
//{
//    Console.WriteLine("Acesso permitido");
//}
//else
//{
//    Console.WriteLine("Acesso Negado");
//}

//int num1, num2, num3;

//Console.WriteLine("Digite 3 números inteiros e te retornarei o maior.\n");

//Console.WriteLine("Digite o primeiro número: \n");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o segundo número: \n");
//num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o terceiro número: \n");
//num3 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2 && num1 > num3)
//{
//    Console.WriteLine($"O primeiro número é o maior ({num1}).");
//}
//else if (num2 > num3)
//{
//    Console.WriteLine($"O segundo número é o maior ({num2}).");
//}
//else
//{
//    Console.WriteLine($"O terceiro número é o maior ({num3}).");
//}

//Console.WriteLine("Digite o valor da compra para ver se tem desconto: ");

//decimal valor = Convert.ToDecimal(Console.ReadLine());
//decimal desconto;

//if (valor > 0 && valor < 100)
//{
//    Console.WriteLine($"Você não possui desconto.\nValor da compra: {valor}");
//}
//else if (valor == 100 && valor <= 200)
//{
//    desconto = valor - (valor / 10);
//    Console.WriteLine($"Você possui desconto de 10%\nValor da compra: {valor}\nDesconto: {desconto}");
//}
//else
//{
//    desconto = valor - (valor * 0.2m);
//    Console.WriteLine($"Você possui desconto de 20%\nValor da compra: {valor}\nDesconto: {desconto}");
//}


//Console.WriteLine("Digite os 3 lados de um triângulo e te direi qual é: ");

//decimal l1, l2, l3;

//Console.WriteLine("Digite o primeiro lado: \n");
//l1 = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Digite o segundo lado: \n");
//l2 = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Digite o terceiro lado: \n");
//l3 = Convert.ToDecimal(Console.ReadLine());

//if ((l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1))
//{
//    if (l1 == l2 && l2 == l3)
//    {
//        Console.WriteLine("É um triângulo EQUILÁTERO. (TODOS OS LADOS IGUAIS)");
//    }
//    else if (l1 == l2 || l1 == l2 || l2 == l3)
//    {
//        Console.WriteLine("É um triângulo ISÓSCELES. (2 LADOS IGUAIS)");
//    }
//    else if (l1 != l2 && l2 != l3)
//    {
//        Console.WriteLine("É um triângulo ESCALENO. (TODOS OS LADOS DIFERENTES");
//    }
//}
//else
//{
//    Console.WriteLine("As medidas não formam um triângulo.");
//}

//Console.WriteLine("digite seu salário: ");

//decimal s = Convert.ToDecimal(Console.ReadLine());
//decimal taxa;

//if (s <= 2000)
//{
//    Console.WriteLine("você está isento de imposto.");
//}
//else if (s <= 3500m)
//{
//    taxa = (s - 2000) * 0.1m;

//    Console.WriteLine($"o valor do imposto a pagar é: {taxa:C}");
//}
//else if (s <= 5000)
//{
//    decimal taxa2 = (s - 3500) * 0.15m;
//    taxa = 150 + taxa2;

//    Console.WriteLine($"o valor do imposto a pagar é: {taxa:C}");
//}
//else
//{
//    decimal taxa3 = (s - 5000) * 0.20m;
//    taxa = 150 + 225 + taxa3;
//    Console.WriteLine($"o valor do imposto a pagar é: {taxa:C}");
//}

//Console.WriteLine("jogo do pedra papel ou tesoura.\n");
//Console.WriteLine("jogador 1 - digite pedra, papel ou tesoura: \n");
//string jogador1 = Console.ReadLine().ToLower();

//Console.WriteLine("jogador 2 - digite pedra, papel ou tesoura: \n");
//string jogador2 = Console.ReadLine().ToLower();

//if (jogador1 == jogador2)
//{
//    Console.WriteLine("empate");
//}
//else if ((jogador1 == "pedra" && jogador2 == "tesoura") ||
//    (jogador1 == "tesoura" && jogador2 == "papel") ||
//    (jogador1 == "papel" && jogador2 == "pedra"))
//{
//    Console.WriteLine("jogador 1 venceu");
//}
//else
//{
//    Console.WriteLine("jogador 2 venceu");
//}


Console.WriteLine("Digite o valor que deseja sacar: ");
int valor = Convert.ToInt32(Console.ReadLine());
int valorOriginal = valor; 

if (valor == 1 || valor == 3)
{
    Console.WriteLine("Valor inválido para saque.");
}
else
{
    int notas100 = valor / 100;
    valor = valor % 100;        

    int notas50 = valor / 50;
    valor = valor % 50;

    int notas20 = valor / 20;
    valor = valor % 20;

    int notas10 = valor / 10;
    valor = valor % 10;

    int notas5 = 0;
    int notas2 = 0;

    if (valor % 2 != 0)
    {
        notas5 = 1;
        valor = valor - 5;
    }

    notas2 = valor / 2;


    Console.WriteLine($"\nSaque de R$ {valorOriginal} realizado com sucesso:");

    if (notas100 > 0) Console.WriteLine($"{notas100} nota(s) de 100");
    if (notas50 > 0) Console.WriteLine($"{notas50} nota(s) de 50");
    if (notas20 > 0) Console.WriteLine($"{notas20} nota(s) de 20");
    if (notas10 > 0) Console.WriteLine($"{notas10} nota(s) de 10");
    if (notas5 > 0) Console.WriteLine($"{notas5} nota(s) de 5");
    if (notas2 > 0) Console.WriteLine($"{notas2} nota(s) de 2");
}