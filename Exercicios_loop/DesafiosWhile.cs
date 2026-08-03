using System;

namespace Exercicios_loop
{
    public class DesafiosWhile
    {
        /// <summary>
        /// 11) A sequência de Fibonacci. Imprima a sequência enquanto o número gerado for menor que 1000.
        /// </summary>
        public static void Exercicio11_Fibonacci()
        {
            int anterior = 0;
            int atual = 1;
            int proximo = anterior + atual;

            Console.WriteLine(anterior);

            while (atual < 1000)
            {
                Console.WriteLine(proximo);

                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            }
        }

        /// <summary>
        /// 12) Conjectura de Collatz. Se par, divide por 2. Se ímpar, multiplica por 3 e soma 1. 
        /// O loop continua até chegar em 1.
        /// </summary>
        public static void Exercicio12_Collatz()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int contador_Collatz = 0;

            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = (num * 3) + 1;
                }
                contador_Collatz++;
                Console.WriteLine(num);
            }

            Console.WriteLine($"A operação levou {contador_Collatz} passo(s) para chegar ao número 1");
        }

        /// <summary>
        /// 13) Combate por turnos em texto.
        /// Batalha continua enquanto Jogador e Monstro tiverem HP > 0.
        /// </summary>
        public static void Exercicio13_CombateRPG()
        {
            Console.WriteLine("Bem vindo ao jogo!!");
            int vidaJogador = 100;
            int vidaMonstro = 150;

            while (vidaJogador > 0 && vidaMonstro > 0)
            {
                Console.WriteLine("\nDigite:\n1 - Ataque Rápido (15 de dano)\n2 - Ataque Forte (30 de dano, mas toma 10 de recuo)");
                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        vidaMonstro -= 15;
                        if (vidaMonstro > 0)
                        {
                            Console.WriteLine($"Você usou o Ataque Rápido!!\nVida do Monstro = {vidaMonstro}");
                            vidaJogador -= 20;
                            Console.WriteLine($"Você recebeu um golpe do monstro :(\nVida Atual: {vidaJogador}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nVocê usou o Ataque Forte!");
                        vidaMonstro -= 30;
                        vidaJogador -= 10;
                        Console.WriteLine($"Você tomou 10 de dano de recuo. Sua vida: {vidaJogador}");

                        if (vidaMonstro > 0)
                        {
                            vidaJogador -= 20;
                            Console.WriteLine($"O monstro sobreviveu com {vidaMonstro} HP e revidou!");
                            Console.WriteLine($"Você tomou 20 de dano do monstro. Vida Atual: {vidaJogador}");
                        }
                        else
                        {
                            Console.WriteLine("O monstro foi esmagado pelo seu ataque!");
                        }
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }

            if (vidaJogador <= 0 && vidaMonstro > 0)
            {
                Console.WriteLine("\nVocê perdeu! :(");
            }
            else
            {
                Console.WriteLine("\nVocê ganhou!! Parabéns");
            }
        }
    }
}