using System;

namespace exercicios_for
{
    public class LacosFor
    {
        /// <summary>
        /// 1) Peça ao usuário um número. Usando um for, imprima a tabuada desse número do 1 ao 10.
        /// </summary>
        public static void Exercicio1_Tabuada()
        {
            Console.WriteLine("Digite um número e te darei a tabuada:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }

        /// <summary>
        /// 2) Faça um for que conte de 1 a 20. Dentro dele, use um if/else para imprimir se é par ou ímpar.
        /// </summary>
        public static void Exercicio2_ParOuImpar()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} é par");
                }
                else
                {
                    Console.WriteLine($"{i} é impar");
                }
            }
        }

        /// <summary>
        /// 3) Faça um for que comece no 100 e vá diminuindo até o 0, mas pulando de 5 em 5.
        /// </summary>
        public static void Exercicio3_ContagemRegressiva()
        {
            for (int i = 100; i >= 0; i -= 5)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// 4) Peça ao usuário um número inteiro (N). Faça um for que some todos os números de 1 até N e imprima o resultado final.
        /// </summary>
        public static void Exercicio4_SomaAteN()
        {
            Console.WriteLine("Digite um número e te darei a soma:");
            int num = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= num; i++)
            {
                soma += i;
                Console.Write(i);

                if (i < num)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine($" = {soma}");
        }
    }
}