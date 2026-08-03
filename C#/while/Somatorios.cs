using System;

namespace SeusExercicios
{
    public class Somatorios
    {
        /// <summary>
        /// 6) O programa deve pedir para o usuário digitar números inteiros.
        /// Ele deve ir somando todos os números digitados em uma variável total.
        /// O loop só deve parar quando o usuário digitar o número 0.
        /// No final (fora do loop), imprima: "A soma de todos os números digitados é: X".
        /// </summary>
        public static void Exercicio6_SomaAteZero()
        {
            Console.WriteLine("Digite números inteiros que te darei a soma dos mesmos: \nPara encerrar, digite 0.\n");
            int soma = 0;

            while (true)
            {
                Console.WriteLine("Digite um número: \n");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                soma += numeroDigitado;

                if (numeroDigitado == 0) break;
            }
            Console.WriteLine($"A soma dos números digitados é: {soma}");
        }
    }
}