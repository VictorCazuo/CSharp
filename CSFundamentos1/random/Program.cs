using System;

namespace TrabalhandoComRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PORTFÓLIO: A CLASSE RANDOM ===\n");

            Exercicio1MegaSena();
            Console.WriteLine(new string('-', 50));

            Exercicio2LootBox();
            Console.WriteLine(new string('-', 50));

            Exercicio3AcertoCritico();
        }

        /// <summary>
        /// Exercício 1: Gerador da Mega-Sena
        /// Objetivo: Gerar 6 números aleatórios entre 1 e 60 usando limite exclusivo.
        /// </summary>
        static void Exercicio1MegaSena()
        {
            Console.WriteLine("--- 1. Sorteio da Mega-Sena ---");
            Console.WriteLine("Números da sorte:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{Random.Shared.Next(1, 61)} ");
            }

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Exercício 2: Loot Box
        /// Objetivo: Sortear um item de um array usando Random.Shared como índice.
        /// </summary>
        static void Exercicio2LootBox()
        {
            Console.WriteLine("--- 2. Abertura de Loot Box ---");

            string[] recompensas = { "Poção de vida", "Espada Enferrujada", "100 moedas de ouro", "Escudo Épico" };
            int resultado = Random.Shared.Next(recompensas.Length);

            Console.WriteLine($"O item sorteado foi: {recompensas[resultado]}");
            Console.WriteLine();
        }

        /// <summary>
        /// Exercício 3: Probabilidade de Acerto Crítico
        /// Objetivo: Usar NextDouble para calcular 25% de chance de um evento.
        /// </summary>
        static void Exercicio3AcertoCritico()
        {
            Console.WriteLine("--- 3. Probabilidade de Acerto Crítico ---");
            Console.WriteLine("Chance de dano crítico = 25%\n");

            double danoBase = 50.0;
            double multiplicarDano = Random.Shared.NextDouble();

            if (multiplicarDano <= 0.25)
            {
                Console.WriteLine($"Acertou o crítico. Você causou {danoBase * 2} de dano");
            }
            else
            {
                Console.WriteLine($"Você causou {danoBase} de dano");
            }
        }
    }
}