using System;

namespace SeusExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Crie um programa que imprima os números de 1 a 10, um embaixo do outro

            //int contador = 1;

            //while (contador <= 10)
            //{
            //    Console.WriteLine(contador);
            //    contador++;
            //}

            //2)Faça uma contagem regressiva. O programa deve imprimir de 10 até 0.
            //Quando chegar no 0, em vez de imprimir o número, imprima "Fogo!!".

            int contador = 10;

            while (contador >= 0)
            {
                if (contador == 0)
                {
                    Console.WriteLine("Fogo!!");
                }
                else
                {
                    Console.WriteLine(contador);
                }
                contador--;

            }

            //3) Faça um programa que imprima apenas os números pares entre 2 e 20.
            //Faça apenas manipulando o incremento da variável (ex: somando + 2 a cada volta), sem usar if.

            int pares = 2;

            while (pares <= 20)
            {
                Console.WriteLine(pares);
                pares += 2;
            }

            //4) O programa deve pedir para o usuário digitar uma palavra e, em seguida, repeti-la na tela.
            //Ele deve continuar fazendo isso enquanto o usuário não digitar a palavra "sair".

            while (true)
            {
                Console.WriteLine("Digite uma palavra: \nDigite (Sair) quando desejar parar.\n");

                string palavra = Console.ReadLine().ToLower();
                if (palavra == "sair")
                {
                    break;
                }

                Console.WriteLine($"{palavra}\n");

            }

            //5) Crie uma variável string senhaCorreta = "Csharp123".
            //Peça para o usuário digitar a senha.
            //Enquanto a senha digitada for diferente da correta, imprima "Senha Incorreta, tente novamente" e peça a senha outra vez.
            //Quando ele acertar, o while vai quebrar sozinho. Imprima "Cofre Aberto!" fora do loop.

            string senhaCorreta = "Csharp123";

            string senha = "";

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Digite sua senha: \n");
                senha = Console.ReadLine();
                if (senha != senhaCorreta)
                    Console.WriteLine("Senha incorreta.\n");
            }

            Console.WriteLine("Cofre aberto!!");

            //6) O programa deve pedir para o usuário digitar números inteiros.
            //Ele deve ir somando todos os números digitados em uma variável total.
            //O loop só deve parar quando o usuário digitar o número 0.
            //No final (fora do loop), imprima: "A soma de todos os números digitados é: X".

            Console.WriteLine("Digite números inteiros que te darei a soma dos mesmos: \nPara encerrar, digite 0.\n");

            int soma = 0;

            while (true)
            {
                Console.WriteLine("Digite um número: \n");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                soma += numeroDigitado;

                if (numeroDigitado == 0)
                    break;
            }

            Console.WriteLine($"A soma dos números digitados é: {soma}");

            //7) Peça ao usuário para digitar um número (ex: 7).
            //Use um while com um contador de 1 a 10 para imprimir a tabuada desse número.
            //Exemplo de saída: 7 x 1 = 7, 7 x 2 = 14, etc.

            Console.WriteLine("Digite um número e te darei a sua tabuada: \n");
            int numeroParaTabuada = Convert.ToInt32(Console.ReadLine());
            int contador_t = 1;

            while (contador_t <= 10)
            {
                Console.WriteLine($"{numeroParaTabuada} X {contador_t} = {numeroParaTabuada * contador_t}");
                contador_t++;
            }

            //8) Crie uma variável int numeroSecreto = 42;.
            //Peça para o usuário adivinhar o número.
            //Enquanto ele não acertar, o programa deve dar dicas:
            //Se o chute for maior que 42, imprima "O número secreto é MENOR. Tente de novo:." 
            //Se o chute for menor, imprima "O número secreto é MAIOR. Tente de novo:." 
            //Quando ele acertar, imprima "Parabéns, você acertou!."

            int numeroSecreto = 42;

            while (true)
            {
                Console.WriteLine("Adivinha o número secreto: \n");
                int resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    break;
                }
                else if (resposta < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MAIOR. Tente de novo: \n");
                }
                else
                {
                    Console.WriteLine("O número secreto é MENOR. Tente de novo: \n");
                }
            }

            //9) Crie um menu: "1 - Cadastrar | 2 - Ver Perfil | 3 - Sair".
            //Leia a opção do usuário e use um switch para responder à ação escolhida.
            //Coloque toda essa lógica de mostrar o menu e ler a opção dentro de um while. O loop só deve ser encerrado (usando uma condição falsa ou o comando break) quando a opção for 3.

            while (true)
            {
                Console.WriteLine("Digite (1 - Cadastrar | 2 - Ver Perfil | 3 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Entrando no cadastro...");
                        break;

                    case 2:
                        Console.WriteLine("Entrando no perfil...");
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

                if (opcao == 3)
                {
                    break;
                }
            }

            //10)O usuário tem um double saldo = 1000.00;.
            //Inicie um loop pedindo: "Quanto você deseja sacar? (Digite 0 para sair)".
            //Regras dentro do loop:
            //Se ele pedir mais do que tem no saldo, avise "Saldo Insuficiente" e não desconte.
            //Se tiver saldo, subtraia o valor e mostre o novo saldo.
            //O loop deve continuar enquanto a opção digitada for diferente de 0 E o saldo for maior que 0.
            //Se o saldo zerar, imprima "Sua conta está zerada!" e o programa deve fechar automaticamente.

            double saldo = 1000.00;
            double sacar = -1;

            while (sacar != 0 && saldo > 0)
            {
                Console.WriteLine($"\nSaldo: {saldo:C}. Quanto deseja sacar? (0 para sair)");
                sacar = Convert.ToDouble(Console.ReadLine());

                if (sacar == 0)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                if (sacar > saldo)
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                else
                {
                    saldo -= sacar;
                    Console.WriteLine("Saque realizado.");
                }
            }

            if (saldo <= 0) Console.WriteLine("Sua conta está zerada!");
        }
    }
}