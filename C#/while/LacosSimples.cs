using System;

namespace SeusExercicios
{
    public class LacosSimples
    {
        /// <summary>
        /// 1) Crie um programa que imprima os números de 1 a 10, um embaixo do outro.
        /// </summary>
        public static void Exercicio1_ImprimirAte10()
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }

        /// <summary>
        /// 2) Faça uma contagem regressiva. O programa deve imprimir de 10 até 0.
        /// Quando chegar no 0, em vez de imprimir o número, imprima "Fogo!!".
        /// </summary>
        public static void Exercicio2_ContagemRegressiva()
        {
            int contador = 10;
            while (contador >= 0)
            {
                if (contador == 0) Console.WriteLine("Fogo!!");
                else Console.WriteLine(contador);

                contador--;
            }
        }

        /// <summary>
        /// 3) Faça um programa que imprima apenas os números pares entre 2 e 20.
        /// Faça apenas manipulando o incremento da variável (ex: somando + 2 a cada volta), sem usar if.
        /// </summary>
        public static void Exercicio3_NumerosPares()
        {
            int pares = 2;
            while (pares <= 20)
            {
                Console.WriteLine(pares);
                pares += 2;
            }
        }

        /// <summary>
        /// 7) Peça ao usuário para digitar um número (ex: 7).
        /// Use um while com um contador de 1 a 10 para imprimir a tabuada desse número.
        /// Exemplo de saída: 7 x 1 = 7, 7 x 2 = 14, etc.
        /// </summary>
        public static void Exercicio7_Tabuada()
        {
            Console.WriteLine("Digite um número e te darei a sua tabuada: \n");
            int numeroParaTabuada = Convert.ToInt32(Console.ReadLine());
            int contador_t = 1;

            while (contador_t <= 10)
            {
                Console.WriteLine($"{numeroParaTabuada} X {contador_t} = {numeroParaTabuada * contador_t}");
                contador_t++;
            }
        }
    }
}